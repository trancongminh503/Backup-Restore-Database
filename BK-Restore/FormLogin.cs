using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BK_Restore
{
	public partial class FormLogin : XtraForm
	{
		private bool isLoadServers = false;

		public FormLogin()
		{
			InitializeComponent();
			txtPassword.Properties.PasswordChar = '•';
			cboServers.SelectedIndex = 0;
		}

		public async Task GetListServer()
		{
			cboServers.Items.Clear();
			string myServer = Environment.MachineName;
			DataTable servers = null;
			await Task.Run(() =>
			{
				servers = SqlDataSourceEnumerator.Instance.GetDataSources();
			});
			for (int i = 0; i < servers.Rows.Count; i++)
			{
				if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
				{
					if ((servers.Rows[i]["InstanceName"] as string) != null)
						cboServers.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
					else
						cboServers.Items.Add(servers.Rows[i]["ServerName"].ToString());
				}
			}

			cboServers.SelectedIndex = 0;
		}

		private async void cboServers_DropDown(object sender, EventArgs e)
		{
			if (isLoadServers == false)
			{
				SplashScreenManager.ShowForm(this, typeof(WaitFormCustom), false, false, false, ParentFormState.Locked);
				await GetListServer();
				SplashScreenManager.CloseForm(false);
				isLoadServers = true;
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Program.UserName = txtLogin.Text;
			Program.Password = txtPassword.Text;

			if (Program.Connect() == true)
			{
				FormMain formMain = new FormMain();
				this.Hide();
				formMain.Closed += (s, args) =>
				{
					this.Show();
				};
				formMain.Show();
			}
			else
			{
				XtraMessageBox.Show("Đăng nhập thất bại", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
