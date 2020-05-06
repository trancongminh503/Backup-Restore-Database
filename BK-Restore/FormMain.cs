using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BK_Restore
{
	public partial class FormMain : XtraForm
	{
		public FormMain()
		{
			InitializeComponent();
			txtDatabaseName.DataBindings.Add(new Binding("EditValue", bdsDatabases, "name", true));
			txtBackupPosition.DataBindings.Add(new Binding("EditValue", bdsBackup, "position", true));
			EnableBarItemsHoverEffect();
			dtpDateRestore.DateTime = DateTime.Now;
			timeRestore.Time = DateTime.Now;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void LoadTable()
		{
			this.taDatabases.Connection.ConnectionString
				= this.taDevices.Connection.ConnectionString
				= this.taBackup.Connection.ConnectionString
				= this.taKeys.Connection.ConnectionString
				= this.taBackupSet.Connection.ConnectionString
				= Program.ConnectionString;

			try
			{
				this.taDevices.Fill(this.dataSet.backup_devices);
				this.taDatabases.Fill(this.dataSet.databases);
			}
			catch (Exception ex)
			{
				Program.ShowError(ex);
			}
		}

		public bool IsContainDevice(string dbName)
		{
			return bdsDevices.Find("name", "DEVICE_" + dbName) != -1;
		}

		private void EnableBarItems(bool enable)
		{
			foreach (var itemBar in barManager.Items)
			{
				(itemBar as BarBaseButtonItem).Enabled = enable;
			}
			btnExit.Enabled = true;
			btnReload.Enabled = true;
		}

		private void txtDatabaseName_EditValueChanged(object sender, EventArgs e)
		{
			try
			{
				string dbName = (sender as TextEdit).Text;
				if (string.IsNullOrWhiteSpace(dbName)) return;

				this.taBackup.Fill(this.dataSet.SP_STT_BACKUP, dbName);

				if (IsContainDevice(dbName))
				{
					EnableBarItems(true);
					btnCreateDevice.Enabled = false;
					btnCreateDeviceM.Visible = false;
					btnBackupM.Visible = true;
					if (bdsBackup.Count == 0)
					{
						btnRestore.Enabled = false;
					}
				}
				else
				{
					EnableBarItems(false);
					btnCreateDevice.Enabled = true;
					btnCreateDeviceM.Visible = true;
					btnBackupM.Visible = false;
				}
			}
			catch (Exception ex)
			{
				Program.ShowError(ex);
			}
		}

		private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
		{
			string queryString;
			string dbName = txtDatabaseName.Text;
			string deviceName = Program.CreateDeviceName(dbName);

			if (ckbIsClearOldBackup.Checked)
			{
				if (XtraMessageBox.Show("Hành động này sẽ xóa toàn bộ file backup cũ\n" +
												"Bạn chắc chắn muốn tiếp tục?", "QUESTION",
												MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
					return;
				ClearBackupInBackupSet();
				queryString = string.Format(CONS.QUERYSTRING.BACKUP_WITH_INIT, dbName, deviceName);
			}
			else
				queryString = string.Format(CONS.QUERYSTRING.BACKUP, dbName, deviceName);
			string dienGiai = GetMessageBoxText("TẠO BACKUP", "Nhập diễn giải");
			if(dienGiai == null)
			{
				return;
			}
			if (dienGiai != string.Empty)
			{
				queryString += $" WITH NAME = N'{dienGiai}'";
			}

			int resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
			if (resultExec != 0)
			{
				return;
			}
			else
			{
				XtraMessageBox.Show("Sao lưu thành công", "SUCCESS",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.taBackup.Fill(this.dataSet.SP_STT_BACKUP, dbName);
				//txtBackupPosition.Text = ((DataRowView)bdsBackup[0])["position"].ToString();
				btnRestore.Enabled = true;
			}
		}

		private string GetMessageBoxText(string caption, string label)
		{
			XtraInputBoxArgs args = new XtraInputBoxArgs(this, label, caption, string.Empty);
			var result = XtraInputBox.Show(args);
			return (string)result;
		}

		private void ClearBackupInBackupSet()
		{
			string dbName = txtDatabaseName.Text;
			// trong bdsBackup có thể không đếm đủ toàn bộ backup set
			taBackupSet.Fill(dataSet.backupset, dbName);
			int countBackup = bdsBackupSet.Count;
			for (int index = 0; index < countBackup; index++)
			{
				string backup_set_id = ((DataRowView)bdsBackupSet[index])["backup_set_id"].ToString();
				DeleteBackup(int.Parse(backup_set_id));
			}
		}

		private async void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
		{
			string dbName = txtDatabaseName.Text;
			if (ckbIsRestoreTime.Checked)
			{
				if (IsValidTimeRestore())
				{
					string strStopAt = dtpDateRestore.DateTime.ToString("dd/MM/yyyy") + " "
												+ timeRestore.Time.ToString("hh:mm:ss tt");
					if (XtraMessageBox.Show($"Bạn chắc chắn muốn restore database [{dbName}] về thời điểm [{strStopAt}]?",
													"QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						SplashScreenManager.ShowForm(this, typeof(WaitFormCustom), false, false, false, ParentFormState.Locked);
						int resultExec = await RestoreWithTime();
						SplashScreenManager.CloseForm(false);
						if (resultExec == 0)
						{
							XtraMessageBox.Show("Phục hồi thành công", "SUCCESS",
								MessageBoxButtons.OK, MessageBoxIcon.Information);
							Program.Connect();
						}
						else
						{
							XtraMessageBox.Show($"Phục hồi thất bại\nError State: {resultExec}", "FAIL",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				if (XtraMessageBox.Show($"Bạn chắc chắn muốn restore database [{dbName}] về bản backup [{txtBackupPosition.Text}]?",
													"QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SplashScreenManager.ShowForm(this, typeof(WaitFormCustom), false, false, false, ParentFormState.Locked);
					int resultExec = await Restore();
					SplashScreenManager.CloseForm(false);
					if (resultExec == 0)
					{
						XtraMessageBox.Show("Phục hồi thành công", "SUCCESS",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						XtraMessageBox.Show($"Phục hồi thất bại\nError State: {resultExec}", "FAIL",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private async Task<int> Restore()
		{
			string queryString = string.Format(CONS.QUERYSTRING.RESTORE,
				txtDatabaseName.Text,
				Program.CreateDeviceName(txtDatabaseName.Text),
				txtBackupPosition.Text);
			int resultExec = 0;
			await Task.Run(() =>
			{
				resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				Thread.Sleep(2000);
			});
			return resultExec;
		}

		private async Task<int> RestoreWithTime()
		{
			string dbName = txtDatabaseName.Text;
			string deviceName = Program.CreateDeviceName(dbName);
			string position = txtBackupPosition.Text;
			string strStopAt = dtpDateRestore.DateTime.ToString("yyyy-MM-dd") + " "
												+ timeRestore.Time.ToString("HH:mm:ss");
			string logPath = Program.DefaultPath + $"\\{dbName}.trn";

			string queryString = string.Format(CONS.QUERYSTRING.RESTORE_WITH_TIME_1,
														dbName, logPath, deviceName, position);

			int resultExec = 0;
			await Task.Run(() =>
			{
				resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				Thread.Sleep(500);
			});
			#region ERROR_RESTORE_DEVICE
			if (resultExec != 0)
			{
				queryString = $"RESTORE DATABASE [{dbName}] FROM [{deviceName}] WITH FILE = {position}\n" +
									$"ALTER DATABASE [{dbName}] SET MULTI_USER";
				await Task.Run(() =>
				{
					Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				});
				return resultExec;
			}
			#endregion

			queryString = string.Format(CONS.QUERYSTRING.RESTORE_WITH_TIME_2, dbName, logPath, strStopAt);
			await Task.Run(() =>
			{
				resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				Thread.Sleep(500);
			});
			#region ERROR_RESTORE_LOG
			if (resultExec != 0)
			{
				queryString = $"RESTORE DATABASE [{dbName}] FROM [{deviceName}] WITH FILE = {position}\n" +
									$"ALTER DATABASE [{dbName}] SET MULTI_USER";
				await Task.Run(() =>
				{
					Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				});
				return resultExec;
			}
			#endregion

			queryString = $"ALTER DATABASE [{dbName}] SET MULTI_USER";
			await Task.Run(() =>
			{
				resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);
				Thread.Sleep(500);
			});

			return 0;
		}

		private bool IsValidTimeRestore()
		{
			DateTime ngayGioBackup = (DateTime)((DataRowView)bdsBackup.Current)["backup_start_date"];
			string strThoiDiemStopAt = dtpDateRestore.DateTime.ToString("MM/dd/yyyy") + " "
												+ timeRestore.Time.ToString("HH:mm:ss");
			DateTime thoiDiemStopAt = DateTime.Parse(strThoiDiemStopAt);
			if ((dtpDateRestore.DateTime.Date < ngayGioBackup.Date) ||
				(dtpDateRestore.DateTime.Date == ngayGioBackup.Date &&
				(thoiDiemStopAt.TimeOfDay.Ticks - ngayGioBackup.TimeOfDay.Ticks) < TimeSpan.FromMinutes(3).Ticks))
			{
				XtraMessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã chọn ít nhất 3 phút",
					"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (thoiDiemStopAt > DateTime.Now)
			{
				XtraMessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại",
					"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void btnCreateDevice_ItemClick(object sender, ItemClickEventArgs e)
		{
			string deviceName = Program.CreateDeviceName(txtDatabaseName.Text);
			string physicalName = Program.DefaultPath + "\\" + deviceName + ".bak";
			string queryString = string.Format(CONS.QUERYSTRING.CREATE_DEVICE,
															deviceName, physicalName);

			int resultExec = Program.ExecSqlNonQuery(queryString, Program.ConnectionString);

			if (resultExec == 0)
			{
				XtraMessageBox.Show("Tạo device thành công", "SUCCESS",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.taDevices.Fill(this.dataSet.backup_devices);
				int backupPosition = bdsDatabases.Position;
				bdsDatabases.MoveFirst();
				bdsDatabases.Position = backupPosition;
			}
		}

		private void ckbIsRestoreDaily_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			var ckb = (sender as BarCheckItem);
			if (ckb.Checked)
			{
				pnRestoreTime.Visible = true;
			}
			else
			{
				pnRestoreTime.Visible = false;
			}
		}

		private void tbnExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Close();
		}

		private void FormMain_SizeChanged(object sender, EventArgs e)
		{
			int ckbClearBackupWidth = ckbIsClearOldBackup.Size.Width;
			if (pnExtend.Width < ckbClearBackupWidth)
			{
				ckbIsClearOldBackup.Location = new Point(0, ckbIsClearOldBackup.Location.Y);
			}
			else
			{
				var newLocationOfCheckBox =
					new Point(ckbIsClearOldBackup.Location.X, ckbIsClearOldBackup.Location.Y);
				newLocationOfCheckBox.X = (pnExtend.Width / 2) - (ckbClearBackupWidth / 2);
				ckbIsClearOldBackup.Location = newLocationOfCheckBox;

				lblRestore.Location = new Point(newLocationOfCheckBox.X, lblRestore.Location.Y);
				dtpDateRestore.Location =
					new Point(newLocationOfCheckBox.X + lblRestore.Width + 6, dtpDateRestore.Location.Y);
				timeRestore.Location =
					new Point(newLocationOfCheckBox.X + lblRestore.Width + dtpDateRestore.Width + 12, timeRestore.Location.Y);
				memoEditDoc.Location = new Point(newLocationOfCheckBox.X, memoEditDoc.Location.Y);
			}
		}

		private void EnableBarItemsHoverEffect()
		{
			foreach (var itemBar in barManager.Items)
			{
				(itemBar as BarBaseButtonItem).ItemAppearance.Hovered.Font =
					new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
				(itemBar as BarBaseButtonItem).ItemAppearance.Hovered.BackColor = Color.LightGray;

				(itemBar as BarBaseButtonItem).ItemAppearance.Pressed.Font =
					new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
			}
		}

		private void btnDeleteBackup_Click(object sender, EventArgs e)
		{
			int backupSetId = int.Parse(((DataRowView)bdsBackup.Current)["backup_set_id"].ToString());

			if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa file backup này?", "QUESTION",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			int resultExec = DeleteBackup(backupSetId);

			if (resultExec == 0)
			{
				XtraMessageBox.Show("Đã xóa file backup", "SUCCESS",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				XtraMessageBox.Show($"Xóa file backup thất bại\nError code: {resultExec}", "FAIL",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			taBackup.Fill(dataSet.SP_STT_BACKUP, txtDatabaseName.Text);
			if(bdsBackup.Count == 0)
			{
				btnRestore.Enabled = false;
			}
		}

		private int DeleteBackup(int backupSetId)
		{
			LOG.DEBUG("Delete backup", "backup_set_id", backupSetId);
			taKeys.Fill(dataSet.keys, backupSetId);
			string query = string.Format(CONS.QUERYSTRING.DELETE_BACKUP, backupSetId);

			int restoreCount = bdsKeys.Count;
			if (restoreCount > 0)
			{
				string queryDeleteRestoreHistory = "";
				for (int index = 0; index < restoreCount; index++)
				{
					string restore_history_id = ((DataRowView)bdsKeys[index])["restore_history_id"].ToString();
					queryDeleteRestoreHistory += string.Format(CONS.QUERYSTRING.DELETE_RESTORE_HISTORY, restore_history_id);
				}
				query = queryDeleteRestoreHistory + query;
			}

			return Program.ExecSqlNonQuery(query, Program.ConnectionString);
		}

		private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
		{
			LoadTable();
		}

		private void btnReload_ItemClick(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void cmsBackup_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (bdsBackup.Count == 0)
			{
				btnDeleteBackup.Enabled = false;
				btnRestoreM.Enabled = false;
			}
			else
			{
				btnDeleteBackup.Enabled = true;
				btnRestoreM.Enabled = true;
			}
		}

		private void btnRestoreM_Click(object sender, EventArgs e)
		{
			btnRestore.PerformClick();
		}

		private void btnCreateDeviceM_Click(object sender, EventArgs e)
		{
			btnCreateDevice.PerformClick();
		}

		private void btnBackupM_Click(object sender, EventArgs e)
		{
			btnBackup.PerformClick();
		}

		private void cmsDB_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
	}
}
