namespace BK_Restore
{
	partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
			this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
			this.ckbIsRestoreTime = new DevExpress.XtraBars.BarCheckItem();
			this.btnCreateDevice = new DevExpress.XtraBars.BarButtonItem();
			this.btnReload = new DevExpress.XtraBars.BarButtonItem();
			this.btnExit = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.dataSet = new BK_Restore.DataSet1();
			this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
			this.taDatabases = new BK_Restore.DataSet1TableAdapters.databasesTableAdapter();
			this.gcDatabases = new DevExpress.XtraGrid.GridControl();
			this.cmsBackup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnDeleteBackup = new System.Windows.Forms.ToolStripMenuItem();
			this.btnReload2 = new System.Windows.Forms.ToolStripMenuItem();
			this.gvDatabases = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bdsDevices = new System.Windows.Forms.BindingSource(this.components);
			this.taDevices = new BK_Restore.DataSet1TableAdapters.backup_devicesTableAdapter();
			this.bdsBackup = new System.Windows.Forms.BindingSource(this.components);
			this.taBackup = new BK_Restore.DataSet1TableAdapters.SP_STT_BACKUPTableAdapter();
			this.gcBackup = new DevExpress.XtraGrid.GridControl();
			this.gvBackup = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ckbIsClearOldBackup = new DevExpress.XtraEditors.CheckEdit();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.txtBackupPosition = new DevExpress.XtraEditors.TextEdit();
			this.txtDatabaseName = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.pnExtend = new System.Windows.Forms.Panel();
			this.pnRestoreTime = new System.Windows.Forms.Panel();
			this.memoEditDoc = new DevExpress.XtraEditors.MemoEdit();
			this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
			this.dtpDateRestore = new DevExpress.XtraEditors.DateEdit();
			this.lblRestore = new DevExpress.XtraEditors.LabelControl();
			this.bdsKeys = new System.Windows.Forms.BindingSource(this.components);
			this.taKeys = new BK_Restore.DataSet1TableAdapters.keysTableAdapter();
			this.bdsBackupSet = new System.Windows.Forms.BindingSource(this.components);
			this.taBackupSet = new BK_Restore.DataSet1TableAdapters.backupsetTableAdapter();
			this.cmsDB = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnReload3 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).BeginInit();
			this.cmsBackup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcBackup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBackup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ckbIsClearOldBackup.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBackupPosition.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).BeginInit();
			this.pnExtend.SuspendLayout();
			this.pnRestoreTime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memoEditDoc.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKeys)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBackupSet)).BeginInit();
			this.cmsDB.SuspendLayout();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar,
            this.bar3});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBackup,
            this.btnRestore,
            this.btnCreateDevice,
            this.btnExit,
            this.ckbIsRestoreTime,
            this.btnReload});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 7;
			this.barManager.StatusBar = this.bar3;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.ckbIsRestoreTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCreateDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// btnBackup
			// 
			this.btnBackup.Caption = "SAO LƯU";
			this.btnBackup.Id = 0;
			this.btnBackup.ImageOptions.Image = global::BK_Restore.Properties.Resources.backup3;
			this.btnBackup.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackup.ItemAppearance.Normal.Options.UseFont = true;
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
			// 
			// btnRestore
			// 
			this.btnRestore.Caption = "PHỤC HỒI";
			this.btnRestore.Id = 1;
			this.btnRestore.ImageOptions.Image = global::BK_Restore.Properties.Resources.hdd;
			this.btnRestore.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.ItemAppearance.Normal.Options.UseFont = true;
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
			// 
			// ckbIsRestoreTime
			// 
			this.ckbIsRestoreTime.Caption = "THAM SỐ PHỤC HỒI THEO THỜI GIAN";
			this.ckbIsRestoreTime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
			this.ckbIsRestoreTime.Id = 5;
			this.ckbIsRestoreTime.ImageOptions.Image = global::BK_Restore.Properties.Resources.calendar;
			this.ckbIsRestoreTime.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbIsRestoreTime.ItemAppearance.Normal.Options.UseFont = true;
			this.ckbIsRestoreTime.Name = "ckbIsRestoreTime";
			this.ckbIsRestoreTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ckbIsRestoreTime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.ckbIsRestoreDaily_CheckedChanged);
			// 
			// btnCreateDevice
			// 
			this.btnCreateDevice.Caption = "TẠO DEVICE SAO LƯU";
			this.btnCreateDevice.Id = 3;
			this.btnCreateDevice.ImageOptions.Image = global::BK_Restore.Properties.Resources.save;
			this.btnCreateDevice.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateDevice.ItemAppearance.Normal.Options.UseFont = true;
			this.btnCreateDevice.Name = "btnCreateDevice";
			this.btnCreateDevice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btnCreateDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateDevice_ItemClick);
			// 
			// btnReload
			// 
			this.btnReload.Caption = "LÀM MỚI";
			this.btnReload.Id = 6;
			this.btnReload.ImageOptions.Image = global::BK_Restore.Properties.Resources.refresh;
			this.btnReload.Name = "btnReload";
			this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
			// 
			// btnExit
			// 
			this.btnExit.Caption = "THOÁT";
			this.btnExit.Id = 4;
			this.btnExit.ImageOptions.Image = global::BK_Restore.Properties.Resources.exit;
			this.btnExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ItemAppearance.Normal.Options.UseFont = true;
			this.btnExit.Name = "btnExit";
			this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbnExit_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(1017, 32);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(1017, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 434);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1017, 32);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 434);
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bdsDatabases
			// 
			this.bdsDatabases.DataMember = "databases";
			this.bdsDatabases.DataSource = this.dataSet;
			// 
			// taDatabases
			// 
			this.taDatabases.ClearBeforeFill = true;
			// 
			// gcDatabases
			// 
			this.gcDatabases.ContextMenuStrip = this.cmsDB;
			this.gcDatabases.DataSource = this.bdsDatabases;
			this.gcDatabases.Dock = System.Windows.Forms.DockStyle.Left;
			this.gcDatabases.Location = new System.Drawing.Point(0, 32);
			this.gcDatabases.MainView = this.gvDatabases;
			this.gcDatabases.MenuManager = this.barManager;
			this.gcDatabases.Name = "gcDatabases";
			this.gcDatabases.Size = new System.Drawing.Size(294, 434);
			this.gcDatabases.TabIndex = 5;
			this.gcDatabases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatabases});
			// 
			// cmsBackup
			// 
			this.cmsBackup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteBackup,
            this.btnReload2});
			this.cmsBackup.Name = "cmsBackup";
			this.cmsBackup.Size = new System.Drawing.Size(159, 48);
			this.cmsBackup.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBackup_Opening);
			// 
			// btnDeleteBackup
			// 
			this.btnDeleteBackup.Image = global::BK_Restore.Properties.Resources.trash;
			this.btnDeleteBackup.Name = "btnDeleteBackup";
			this.btnDeleteBackup.Size = new System.Drawing.Size(158, 22);
			this.btnDeleteBackup.Text = "Xóa bản sao lưu";
			this.btnDeleteBackup.Click += new System.EventHandler(this.btnDeleteBackup_Click);
			// 
			// btnReload2
			// 
			this.btnReload2.Image = global::BK_Restore.Properties.Resources.refresh;
			this.btnReload2.Name = "btnReload2";
			this.btnReload2.Size = new System.Drawing.Size(158, 22);
			this.btnReload2.Text = "Làm mới";
			this.btnReload2.Click += new System.EventHandler(this.btnReload_ItemClick);
			// 
			// gvDatabases
			// 
			this.gvDatabases.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvDatabases.Appearance.FocusedRow.Options.UseFont = true;
			this.gvDatabases.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvDatabases.Appearance.SelectedRow.Options.UseFont = true;
			this.gvDatabases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldatabase_id});
			this.gvDatabases.GridControl = this.gcDatabases;
			this.gvDatabases.Name = "gvDatabases";
			this.gvDatabases.OptionsBehavior.Editable = false;
			this.gvDatabases.OptionsView.ShowGroupPanel = false;
			// 
			// colname
			// 
			this.colname.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colname.AppearanceCell.Options.UseFont = true;
			this.colname.AppearanceCell.Options.UseTextOptions = true;
			this.colname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colname.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colname.AppearanceHeader.Options.UseFont = true;
			this.colname.AppearanceHeader.Options.UseTextOptions = true;
			this.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colname.Caption = "TÊN DATABASE";
			this.colname.FieldName = "name";
			this.colname.Name = "colname";
			this.colname.Visible = true;
			this.colname.VisibleIndex = 0;
			// 
			// coldatabase_id
			// 
			this.coldatabase_id.FieldName = "database_id";
			this.coldatabase_id.Name = "coldatabase_id";
			// 
			// bdsDevices
			// 
			this.bdsDevices.DataMember = "backup_devices";
			this.bdsDevices.DataSource = this.dataSet;
			// 
			// taDevices
			// 
			this.taDevices.ClearBeforeFill = true;
			// 
			// bdsBackup
			// 
			this.bdsBackup.DataMember = "SP_STT_BACKUP";
			this.bdsBackup.DataSource = this.dataSet;
			// 
			// taBackup
			// 
			this.taBackup.ClearBeforeFill = true;
			// 
			// gcBackup
			// 
			this.gcBackup.ContextMenuStrip = this.cmsBackup;
			this.gcBackup.DataSource = this.bdsBackup;
			this.gcBackup.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcBackup.Location = new System.Drawing.Point(294, 65);
			this.gcBackup.MainView = this.gvBackup;
			this.gcBackup.MenuManager = this.barManager;
			this.gcBackup.Name = "gcBackup";
			this.gcBackup.Size = new System.Drawing.Size(723, 245);
			this.gcBackup.TabIndex = 6;
			this.gcBackup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBackup});
			// 
			// gvBackup
			// 
			this.gvBackup.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvBackup.Appearance.FocusedRow.Options.UseFont = true;
			this.gvBackup.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvBackup.Appearance.SelectedRow.Options.UseFont = true;
			this.gvBackup.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvBackup.Appearance.ViewCaption.Options.UseFont = true;
			this.gvBackup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
			this.gvBackup.GridControl = this.gcBackup;
			this.gvBackup.Name = "gvBackup";
			this.gvBackup.OptionsBehavior.Editable = false;
			this.gvBackup.OptionsView.ShowGroupPanel = false;
			// 
			// colposition
			// 
			this.colposition.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colposition.AppearanceCell.Options.UseFont = true;
			this.colposition.AppearanceCell.Options.UseTextOptions = true;
			this.colposition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colposition.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colposition.AppearanceHeader.Options.UseFont = true;
			this.colposition.AppearanceHeader.Options.UseTextOptions = true;
			this.colposition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colposition.Caption = "BẢN SAO LƯU THỨ #";
			this.colposition.FieldName = "position";
			this.colposition.Name = "colposition";
			this.colposition.Visible = true;
			this.colposition.VisibleIndex = 0;
			// 
			// colname1
			// 
			this.colname1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colname1.AppearanceCell.Options.UseFont = true;
			this.colname1.AppearanceCell.Options.UseTextOptions = true;
			this.colname1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colname1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colname1.AppearanceHeader.Options.UseFont = true;
			this.colname1.AppearanceHeader.Options.UseTextOptions = true;
			this.colname1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colname1.Caption = "DIỄN GIẢI";
			this.colname1.FieldName = "name";
			this.colname1.Name = "colname1";
			this.colname1.Visible = true;
			this.colname1.VisibleIndex = 1;
			// 
			// colbackup_start_date
			// 
			this.colbackup_start_date.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colbackup_start_date.AppearanceCell.Options.UseFont = true;
			this.colbackup_start_date.AppearanceCell.Options.UseTextOptions = true;
			this.colbackup_start_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colbackup_start_date.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colbackup_start_date.AppearanceHeader.Options.UseFont = true;
			this.colbackup_start_date.AppearanceHeader.Options.UseTextOptions = true;
			this.colbackup_start_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colbackup_start_date.Caption = "NGÀY GIỜ SAO LƯU";
			this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
			this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colbackup_start_date.FieldName = "backup_start_date";
			this.colbackup_start_date.Name = "colbackup_start_date";
			this.colbackup_start_date.Visible = true;
			this.colbackup_start_date.VisibleIndex = 2;
			// 
			// coluser_name
			// 
			this.coluser_name.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coluser_name.AppearanceCell.Options.UseFont = true;
			this.coluser_name.AppearanceCell.Options.UseTextOptions = true;
			this.coluser_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.coluser_name.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coluser_name.AppearanceHeader.Options.UseFont = true;
			this.coluser_name.AppearanceHeader.Options.UseTextOptions = true;
			this.coluser_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.coluser_name.Caption = "USER SAO LƯU";
			this.coluser_name.FieldName = "user_name";
			this.coluser_name.Name = "coluser_name";
			this.coluser_name.Visible = true;
			this.coluser_name.VisibleIndex = 3;
			// 
			// ckbIsClearOldBackup
			// 
			this.ckbIsClearOldBackup.Location = new System.Drawing.Point(6, 6);
			this.ckbIsClearOldBackup.MenuManager = this.barManager;
			this.ckbIsClearOldBackup.Name = "ckbIsClearOldBackup";
			this.ckbIsClearOldBackup.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbIsClearOldBackup.Properties.Appearance.Options.UseFont = true;
			this.ckbIsClearOldBackup.Properties.Caption = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
			this.ckbIsClearOldBackup.Size = new System.Drawing.Size(474, 25);
			this.ckbIsClearOldBackup.TabIndex = 0;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.txtBackupPosition);
			this.panelControl1.Controls.Add(this.txtDatabaseName);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(294, 32);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(723, 33);
			this.panelControl1.TabIndex = 12;
			// 
			// txtBackupPosition
			// 
			this.txtBackupPosition.Location = new System.Drawing.Point(371, 4);
			this.txtBackupPosition.MenuManager = this.barManager;
			this.txtBackupPosition.Name = "txtBackupPosition";
			this.txtBackupPosition.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBackupPosition.Properties.Appearance.Options.UseFont = true;
			this.txtBackupPosition.Properties.ReadOnly = true;
			this.txtBackupPosition.Size = new System.Drawing.Size(50, 24);
			this.txtBackupPosition.TabIndex = 2;
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Location = new System.Drawing.Point(146, 4);
			this.txtDatabaseName.MenuManager = this.barManager;
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDatabaseName.Properties.Appearance.Options.UseFont = true;
			this.txtDatabaseName.Properties.ReadOnly = true;
			this.txtDatabaseName.Size = new System.Drawing.Size(219, 24);
			this.txtDatabaseName.TabIndex = 1;
			this.txtDatabaseName.EditValueChanged += new System.EventHandler(this.txtDatabaseName_EditValueChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(5, 7);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(135, 17);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Tên database phục hồi:";
			// 
			// pnExtend
			// 
			this.pnExtend.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnExtend.Controls.Add(this.ckbIsClearOldBackup);
			this.pnExtend.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnExtend.Location = new System.Drawing.Point(294, 310);
			this.pnExtend.Name = "pnExtend";
			this.pnExtend.Size = new System.Drawing.Size(723, 40);
			this.pnExtend.TabIndex = 17;
			// 
			// pnRestoreTime
			// 
			this.pnRestoreTime.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnRestoreTime.Controls.Add(this.memoEditDoc);
			this.pnRestoreTime.Controls.Add(this.timeRestore);
			this.pnRestoreTime.Controls.Add(this.dtpDateRestore);
			this.pnRestoreTime.Controls.Add(this.lblRestore);
			this.pnRestoreTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnRestoreTime.Location = new System.Drawing.Point(294, 350);
			this.pnRestoreTime.Name = "pnRestoreTime";
			this.pnRestoreTime.Size = new System.Drawing.Size(723, 116);
			this.pnRestoreTime.TabIndex = 22;
			this.pnRestoreTime.Visible = false;
			// 
			// memoEditDoc
			// 
			this.memoEditDoc.EditValue = resources.GetString("memoEditDoc.EditValue");
			this.memoEditDoc.Location = new System.Drawing.Point(6, 29);
			this.memoEditDoc.MenuManager = this.barManager;
			this.memoEditDoc.Name = "memoEditDoc";
			this.memoEditDoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.memoEditDoc.Properties.Appearance.Options.UseFont = true;
			this.memoEditDoc.Properties.ReadOnly = true;
			this.memoEditDoc.Size = new System.Drawing.Size(474, 67);
			this.memoEditDoc.TabIndex = 4;
			// 
			// timeRestore
			// 
			this.timeRestore.EditValue = new System.DateTime(2020, 4, 25, 0, 0, 0, 0);
			this.timeRestore.Location = new System.Drawing.Point(380, 3);
			this.timeRestore.MenuManager = this.barManager;
			this.timeRestore.Name = "timeRestore";
			this.timeRestore.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeRestore.Properties.Appearance.Options.UseFont = true;
			this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.timeRestore.Size = new System.Drawing.Size(100, 24);
			this.timeRestore.TabIndex = 2;
			// 
			// dtpDateRestore
			// 
			this.dtpDateRestore.EditValue = null;
			this.dtpDateRestore.Location = new System.Drawing.Point(240, 3);
			this.dtpDateRestore.MenuManager = this.barManager;
			this.dtpDateRestore.Name = "dtpDateRestore";
			this.dtpDateRestore.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateRestore.Properties.Appearance.Options.UseFont = true;
			this.dtpDateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpDateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpDateRestore.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
			this.dtpDateRestore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtpDateRestore.Properties.EditFormat.FormatString = "dd/MM/yyyy";
			this.dtpDateRestore.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dtpDateRestore.Properties.Mask.EditMask = "dd/MM/yyyy";
			this.dtpDateRestore.Size = new System.Drawing.Size(134, 24);
			this.dtpDateRestore.TabIndex = 1;
			// 
			// lblRestore
			// 
			this.lblRestore.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestore.Appearance.Options.UseFont = true;
			this.lblRestore.Location = new System.Drawing.Point(6, 6);
			this.lblRestore.Name = "lblRestore";
			this.lblRestore.Size = new System.Drawing.Size(228, 17);
			this.lblRestore.TabIndex = 0;
			this.lblRestore.Text = "Ngày giờ để phục hồi tới thời điểm đó:";
			// 
			// bdsKeys
			// 
			this.bdsKeys.DataMember = "keys";
			this.bdsKeys.DataSource = this.dataSet;
			// 
			// taKeys
			// 
			this.taKeys.ClearBeforeFill = true;
			// 
			// bdsBackupSet
			// 
			this.bdsBackupSet.DataMember = "backupset";
			this.bdsBackupSet.DataSource = this.dataSet;
			// 
			// taBackupSet
			// 
			this.taBackupSet.ClearBeforeFill = true;
			// 
			// cmsDB
			// 
			this.cmsDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload3});
			this.cmsDB.Name = "cmsDB";
			this.cmsDB.Size = new System.Drawing.Size(122, 26);
			// 
			// btnReload3
			// 
			this.btnReload3.Image = global::BK_Restore.Properties.Resources.refresh;
			this.btnReload3.Name = "btnReload3";
			this.btnReload3.Size = new System.Drawing.Size(121, 22);
			this.btnReload3.Text = "Làm mới";
			this.btnReload3.Click += new System.EventHandler(this.btnReload_ItemClick);
			// 
			// FormMain
			// 
			this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 489);
			this.Controls.Add(this.pnRestoreTime);
			this.Controls.Add(this.pnExtend);
			this.Controls.Add(this.gcBackup);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.gcDatabases);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "BACKUP - RESTORE DATABASE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).EndInit();
			this.cmsBackup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcBackup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBackup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ckbIsClearOldBackup.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBackupPosition.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName.Properties)).EndInit();
			this.pnExtend.ResumeLayout(false);
			this.pnRestoreTime.ResumeLayout(false);
			this.pnRestoreTime.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.memoEditDoc.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsKeys)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdsBackupSet)).EndInit();
			this.cmsDB.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar;
		private DevExpress.XtraBars.BarButtonItem btnBackup;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem btnRestore;
		private DevExpress.XtraBars.BarButtonItem btnCreateDevice;
		private DevExpress.XtraBars.BarButtonItem btnExit;
		private DevExpress.XtraBars.BarCheckItem ckbIsRestoreTime;
		private System.Windows.Forms.BindingSource bdsDatabases;
		private DataSet1 dataSet;
		private DataSet1TableAdapters.databasesTableAdapter taDatabases;
		private DevExpress.XtraGrid.GridControl gcDatabases;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDatabases;
		private DevExpress.XtraGrid.Columns.GridColumn colname;
		private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
		private System.Windows.Forms.BindingSource bdsDevices;
		private DataSet1TableAdapters.backup_devicesTableAdapter taDevices;
		private System.Windows.Forms.BindingSource bdsBackup;
		private DataSet1TableAdapters.SP_STT_BACKUPTableAdapter taBackup;
		private DevExpress.XtraGrid.GridControl gcBackup;
		private DevExpress.XtraGrid.Views.Grid.GridView gvBackup;
		private DevExpress.XtraGrid.Columns.GridColumn colposition;
		private DevExpress.XtraGrid.Columns.GridColumn colname1;
		private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
		private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
		private DevExpress.XtraEditors.CheckEdit ckbIsClearOldBackup;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.TextEdit txtDatabaseName;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Panel pnExtend;
		private System.Windows.Forms.Panel pnRestoreTime;
		private DevExpress.XtraEditors.LabelControl lblRestore;
		private DevExpress.XtraEditors.DateEdit dtpDateRestore;
		private DevExpress.XtraEditors.TimeEdit timeRestore;
		private DevExpress.XtraEditors.MemoEdit memoEditDoc;
		private DevExpress.XtraEditors.TextEdit txtBackupPosition;
		private System.Windows.Forms.ContextMenuStrip cmsBackup;
		private System.Windows.Forms.ToolStripMenuItem btnDeleteBackup;
		private System.Windows.Forms.BindingSource bdsKeys;
		private DataSet1TableAdapters.keysTableAdapter taKeys;
		private System.Windows.Forms.BindingSource bdsBackupSet;
		private DataSet1TableAdapters.backupsetTableAdapter taBackupSet;
		private DevExpress.XtraBars.BarButtonItem btnReload;
		private System.Windows.Forms.ToolStripMenuItem btnReload2;
		private System.Windows.Forms.ContextMenuStrip cmsDB;
		private System.Windows.Forms.ToolStripMenuItem btnReload3;
	}
}