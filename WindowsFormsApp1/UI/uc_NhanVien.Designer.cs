namespace WindowsFormsApp1.UI
{
    partial class uc_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_NhanVien));
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManagerNhanVien = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Exit_ucNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtGT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupTTNV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtSDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtGioiTinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtManv = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.qLCHMTDataSet5 = new WindowsFormsApp1.QLCHMTDataSet5();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter1 = new WindowsFormsApp1.QLCHMTDataSet5TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // barManagerNhanVien
            // 
            this.barManagerNhanVien.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManagerNhanVien.DockControls.Add(this.barDockControlTop);
            this.barManagerNhanVien.DockControls.Add(this.barDockControlBottom);
            this.barManagerNhanVien.DockControls.Add(this.barDockControlLeft);
            this.barManagerNhanVien.DockControls.Add(this.barDockControlRight);
            this.barManagerNhanVien.Form = this;
            this.barManagerNhanVien.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem4,
            this.Exit_ucNhanVien,
            this.btnSave,
            this.btnLamMoi});
            this.barManagerNhanVien.MainMenu = this.bar2;
            this.barManagerNhanVien.MaxItemId = 7;
            this.barManagerNhanVien.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            resources.ApplyResources(this.bar1, "bar1");
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(380, 132);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // btnThem
            // 
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLamMoi
            // 
            resources.ApplyResources(this.btnLamMoi, "btnLamMoi");
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
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
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManagerNhanVien;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManagerNhanVien;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManagerNhanVien;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManagerNhanVien;
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Exit_ucNhanVien
            // 
            resources.ApplyResources(this.Exit_ucNhanVien, "Exit_ucNhanVien");
            this.Exit_ucNhanVien.Id = 4;
            this.Exit_ucNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_ucNhanVien.ImageOptions.Image")));
            this.Exit_ucNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Exit_ucNhanVien.ImageOptions.LargeImage")));
            this.Exit_ucNhanVien.Name = "Exit_ucNhanVien";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Id = 5;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            // 
            // barButtonItem6
            // 
            resources.ApplyResources(this.barButtonItem6, "barButtonItem6");
            this.barButtonItem6.Id = 2;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // gridBand1
            // 
            resources.ApplyResources(this.gridBand1, "gridBand1");
            this.gridBand1.VisibleIndex = -1;
            // 
            // nhanVienTableAdapter
            // 
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDanhSach);
            this.layoutControl1.Controls.Add(this.txtSoDT);
            this.layoutControl1.Controls.Add(this.txtDC);
            this.layoutControl1.Controls.Add(this.txtGT);
            this.layoutControl1.Controls.Add(this.txtMaNhanVien);
            this.layoutControl1.Controls.Add(this.txtTenNV);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.DataSource = this.nhanVienBindingSource1;
            resources.ApplyResources(this.gcDanhSach, "gcDanhSach");
            this.gcDanhSach.MainView = this.gridView1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colSDT,
            this.colDiaChi});
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            resources.ApplyResources(this.colMaNV, "colMaNV");
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MinWidth = 25;
            this.colHoTen.Name = "colHoTen";
            resources.ApplyResources(this.colHoTen, "colHoTen");
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 25;
            this.colGioiTinh.Name = "colGioiTinh";
            resources.ApplyResources(this.colGioiTinh, "colGioiTinh");
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            resources.ApplyResources(this.colSDT, "colSDT");
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            resources.ApplyResources(this.colDiaChi, "colDiaChi");
            // 
            // txtSoDT
            // 
            resources.ApplyResources(this.txtSoDT, "txtSoDT");
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.StyleController = this.layoutControl1;
            // 
            // txtDC
            // 
            resources.ApplyResources(this.txtDC, "txtDC");
            this.txtDC.Name = "txtDC";
            this.txtDC.StyleController = this.layoutControl1;
            // 
            // txtGT
            // 
            resources.ApplyResources(this.txtGT, "txtGT");
            this.txtGT.Name = "txtGT";
            this.txtGT.StyleController = this.layoutControl1;
            // 
            // txtMaNhanVien
            // 
            resources.ApplyResources(this.txtMaNhanVien, "txtMaNhanVien");
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.StyleController = this.layoutControl1;
            // 
            // txtTenNV
            // 
            resources.ApplyResources(this.txtTenNV, "txtTenNV");
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.StyleController = this.layoutControl1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupTTNV,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(863, 559);
            this.Root.TextVisible = false;
            // 
            // groupTTNV
            // 
            resources.ApplyResources(this.groupTTNV, "groupTTNV");
            this.groupTTNV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txtSDT,
            this.txtDiaChi,
            this.txtGioiTinh,
            this.txtManv,
            this.txtHoTen});
            this.groupTTNV.Location = new System.Drawing.Point(0, 0);
            this.groupTTNV.Name = "groupTTNV";
            this.groupTTNV.OptionsItemText.TextToControlDistance = 3;
            this.groupTTNV.Size = new System.Drawing.Size(252, 539);
            // 
            // txtSDT
            // 
            this.txtSDT.Control = this.txtSoDT;
            resources.ApplyResources(this.txtSDT, "txtSDT");
            this.txtSDT.Location = new System.Drawing.Point(0, 135);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 45);
            this.txtSDT.TextLocation = DevExpress.Utils.Locations.Top;
            this.txtSDT.TextSize = new System.Drawing.Size(79, 16);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Control = this.txtDC;
            resources.ApplyResources(this.txtDiaChi, "txtDiaChi");
            this.txtDiaChi.Location = new System.Drawing.Point(0, 180);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 309);
            this.txtDiaChi.TextLocation = DevExpress.Utils.Locations.Top;
            this.txtDiaChi.TextSize = new System.Drawing.Size(79, 16);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Control = this.txtGT;
            resources.ApplyResources(this.txtGioiTinh, "txtGioiTinh");
            this.txtGioiTinh.Location = new System.Drawing.Point(0, 90);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(228, 45);
            this.txtGioiTinh.TextLocation = DevExpress.Utils.Locations.Top;
            this.txtGioiTinh.TextSize = new System.Drawing.Size(79, 16);
            // 
            // txtManv
            // 
            this.txtManv.Control = this.txtMaNhanVien;
            resources.ApplyResources(this.txtManv, "txtManv");
            this.txtManv.Location = new System.Drawing.Point(0, 0);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(228, 45);
            this.txtManv.TextLocation = DevExpress.Utils.Locations.Top;
            this.txtManv.TextSize = new System.Drawing.Size(79, 16);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Control = this.txtTenNV;
            resources.ApplyResources(this.txtHoTen, "txtHoTen");
            this.txtHoTen.Location = new System.Drawing.Point(0, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 45);
            this.txtHoTen.TextLocation = DevExpress.Utils.Locations.Top;
            this.txtHoTen.TextSize = new System.Drawing.Size(79, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcDanhSach;
            this.layoutControlItem2.Location = new System.Drawing.Point(252, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(591, 539);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(685, 332);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // qLCHMTDataSet5
            // 
            this.qLCHMTDataSet5.DataSetName = "QLCHMTDataSet5";
            this.qLCHMTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.qLCHMTDataSet5;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // uc_NhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_NhanVien";
            this.Load += new System.EventHandler(this.uc_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerNhanVien;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem Exit_ucNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        public System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtSoDT;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtGT;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraLayout.LayoutControlGroup groupTTNV;
        private DevExpress.XtraLayout.LayoutControlItem txtSDT;
        private DevExpress.XtraLayout.LayoutControlItem txtDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem txtGioiTinh;
        private DevExpress.XtraLayout.LayoutControlItem txtManv;
        private DevExpress.XtraLayout.LayoutControlItem txtHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private QLCHMTDataSet5 qLCHMTDataSet5;
        private QLCHMTDataSet5TableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
    }
}
