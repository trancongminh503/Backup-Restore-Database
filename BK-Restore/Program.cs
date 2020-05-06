using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BK_Restore
{
	static class Program
	{
		public static string ConnectionString;
		public static SqlDataAdapter DataAdapter = null;

		public static string ServerName = null;
		public static string UserName = null;
		public static string Password = null;
		public static string TempDatabaseName = "tempdb";

		public static int BeginYear = 2020; // để cho cmbNK tự động tính dựa vào năm này
		public static int RestoreFlag = 0; // để kiểm tra user có phục hồi csdl
		public static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + "\\Devices";

		public static bool Connect()
		{
			try
			{
				ConnectionString = $"Data Source={ServerName};" +
										  $"Initial Catalog={TempDatabaseName};" +
										  $"User ID={UserName};" +
										  $"password={Password}";
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					connection.Open();
				}
				return true;
			}
			catch (Exception)
			{
				//ShowError(ex);
				return false;
			}
		}

		public static int ExecSqlNonQuery(string cmdText, string connectionString)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(cmdText, connection))
				{
					command.CommandType = CommandType.Text;
					command.CommandTimeout = 600; //10p
					try
					{
						command.ExecuteNonQuery();
						return 0;
					}
					catch (SqlException ex)
					{
						ShowError(ex, false);
						return ex.State; // trang thai loi goi tu RAISERROR
					}
				}
			}
		}

		public static string CreateDeviceName(string databaseName)
		{
			return string.Format("DEVICE_{0}", databaseName);
		}

		public static void CreateFolderDevice()
		{
			if (!System.IO.File.Exists(DefaultPath))
			{
				System.IO.Directory.CreateDirectory(DefaultPath);
			}
		}

		public static void ShowError(Exception e, bool isShowMessageBox = true)
		{
			//if (e is SqlException)
			//{
			//   Console.WriteLine("MsgNumber: {0}", ((SqlException)e).Number.ToString());
			//   Console.WriteLine((e as SqlException).Message);
			//}
			string message = e.Message + "\n";
			string source = "Source: " + e.Source + "\n";
			string targetSite = "Method: " + e.TargetSite + "\n";
			if (isShowMessageBox)
				XtraMessageBox.Show(source + targetSite + message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Console.WriteLine(source + targetSite + message + "\n" + e.StackTrace);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			CreateFolderDevice();
			Application.Run(new FormLogin());
		}
	}
}
