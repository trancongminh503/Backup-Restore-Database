namespace BK_Restore
{
	partial class FormLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.cboServers = new System.Windows.Forms.ComboBox();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtLogin = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnExit = new DevExpress.XtraEditors.SimpleButton();
			this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// splashScreenManager
			// 
			splashScreenManager.ClosingDelay = 500;
			// 
			// cboServers
			// 
			this.cboServers.BackColor = System.Drawing.Color.White;
			this.cboServers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboServers.FormattingEnabled = true;
			this.cboServers.Items.AddRange(new object[] {
            "MINHTRAN"});
			this.cboServers.Location = new System.Drawing.Point(178, 30);
			this.cboServers.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.cboServers.Name = "cboServers";
			this.cboServers.Size = new System.Drawing.Size(223, 24);
			this.cboServers.TabIndex = 11;
			this.cboServers.DropDown += new System.EventHandler(this.cboServers_DropDown);
			// 
			// txtPassword
			// 
			this.txtPassword.EditValue = "123456";
			this.txtPassword.Location = new System.Drawing.Point(178, 122);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Properties.Appearance.Options.UseFont = true;
			this.txtPassword.Properties.Appearance.Options.UseImage = true;
			this.txtPassword.Size = new System.Drawing.Size(223, 22);
			this.txtPassword.TabIndex = 15;
			// 
			// txtLogin
			// 
			this.txtLogin.EditValue = "sa";
			this.txtLogin.Location = new System.Drawing.Point(178, 75);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.Properties.Appearance.Options.UseFont = true;
			this.txtLogin.Size = new System.Drawing.Size(223, 22);
			this.txtLogin.TabIndex = 13;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(31, 125);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(68, 16);
			this.labelControl3.TabIndex = 14;
			this.labelControl3.Text = "Password:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(31, 78);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(40, 16);
			this.labelControl2.TabIndex = 12;
			this.labelControl2.Text = "Login:";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(31, 33);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(89, 16);
			this.labelControl1.TabIndex = 10;
			this.labelControl1.Text = "Server name:";
			// 
			// btnExit
			// 
			this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Appearance.Options.UseFont = true;
			this.btnExit.ImageOptions.Image = global::BK_Restore.Properties.Resources.logout;
			this.btnExit.Location = new System.Drawing.Point(297, 163);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(104, 33);
			this.btnExit.TabIndex = 18;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Appearance.Options.UseFont = true;
			this.btnLogin.ImageOptions.Image = global::BK_Restore.Properties.Resources.data_security;
			this.btnLogin.Location = new System.Drawing.Point(178, 163);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(104, 33);
			this.btnLogin.TabIndex = 16;
			this.btnLogin.Text = "Connect";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// FormLogin
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 227);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.cboServers);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connect to Server";
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnExit;
		private System.Windows.Forms.ComboBox cboServers;
		private DevExpress.XtraEditors.SimpleButton btnLogin;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraEditors.TextEdit txtLogin;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}