namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ControlDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.dmNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator6 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator7 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator8 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator9 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator10 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.dmKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.dmNCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tkDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.qlTTLT = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.qlHDB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.qlHDN = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CapTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Thoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.mainContainer.Appearance.Options.UseBackColor = true;
            this.mainContainer.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
            this.mainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(338, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(745, 667);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlDanhMuc,
            this.ControlThongKe,
            this.ControlTaiKhoan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(338, 667);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ControlDanhMuc
            // 
            this.ControlDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.dmNhanVien,
            this.dmKhachHang,
            this.dmNCC});
            this.ControlDanhMuc.Expanded = true;
            this.ControlDanhMuc.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.ControlDanhMuc.Name = "ControlDanhMuc";
            this.ControlDanhMuc.Text = "DANH MỤC";
            // 
            // dmNhanVien
            // 
            this.dmNhanVien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.accordionControlSeparator2,
            this.accordionControlSeparator3,
            this.accordionControlSeparator4,
            this.accordionControlSeparator5,
            this.accordionControlSeparator6,
            this.accordionControlSeparator7,
            this.accordionControlSeparator8,
            this.accordionControlSeparator9,
            this.accordionControlSeparator10});
            this.dmNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dmNhanVien.ImageOptions.Image")));
            this.dmNhanVien.Name = "dmNhanVien";
            this.dmNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.dmNhanVien.Text = "DANH MỤC NHÂN VIÊN";
            this.dmNhanVien.Click += new System.EventHandler(this.dmNhanVien_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            this.accordionControlSeparator1.Visible = false;
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            this.accordionControlSeparator2.Visible = false;
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            this.accordionControlSeparator3.Visible = false;
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            this.accordionControlSeparator4.Visible = false;
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            this.accordionControlSeparator5.Visible = false;
            // 
            // accordionControlSeparator6
            // 
            this.accordionControlSeparator6.Name = "accordionControlSeparator6";
            this.accordionControlSeparator6.Visible = false;
            // 
            // accordionControlSeparator7
            // 
            this.accordionControlSeparator7.Name = "accordionControlSeparator7";
            this.accordionControlSeparator7.Visible = false;
            // 
            // accordionControlSeparator8
            // 
            this.accordionControlSeparator8.Name = "accordionControlSeparator8";
            this.accordionControlSeparator8.Visible = false;
            // 
            // accordionControlSeparator9
            // 
            this.accordionControlSeparator9.Name = "accordionControlSeparator9";
            this.accordionControlSeparator9.Visible = false;
            // 
            // accordionControlSeparator10
            // 
            this.accordionControlSeparator10.Name = "accordionControlSeparator10";
            this.accordionControlSeparator10.Visible = false;
            // 
            // dmKhachHang
            // 
            this.dmKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dmKhachHang.ImageOptions.Image")));
            this.dmKhachHang.Name = "dmKhachHang";
            this.dmKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.dmKhachHang.Text = "DANH MỤC KHÁCH HÀNG";
            this.dmKhachHang.Click += new System.EventHandler(this.dmKhachHang_Click);
            // 
            // dmNCC
            // 
            this.dmNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dmNCC.ImageOptions.Image")));
            this.dmNCC.Name = "dmNCC";
            this.dmNCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.dmNCC.Text = "DANH MỤC NHÀ CUNG CẤP";
            this.dmNCC.Click += new System.EventHandler(this.dmNCC_Click);
            // 
            // ControlThongKe
            // 
            this.ControlThongKe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.tkDoanhThu,
            this.qlTTLT,
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.ControlThongKe.Expanded = true;
            this.ControlThongKe.Name = "ControlThongKe";
            this.ControlThongKe.Text = "QUẢN LÝ";
            this.ControlThongKe.Click += new System.EventHandler(this.ControlThongKe_Click);
            // 
            // tkDoanhThu
            // 
            this.tkDoanhThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tkDoanhThu.ImageOptions.Image")));
            this.tkDoanhThu.Name = "tkDoanhThu";
            this.tkDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.tkDoanhThu.Text = "DOANH THU";
            this.tkDoanhThu.Click += new System.EventHandler(this.tkDoanhThu_Click);
            // 
            // qlTTLT
            // 
            this.qlTTLT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("qlTTLT.ImageOptions.SvgImage")));
            this.qlTTLT.Name = "qlTTLT";
            this.qlTTLT.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.qlTTLT.Text = "THÔNG TIN LAPTOP";
            this.qlTTLT.Click += new System.EventHandler(this.qlTTLT_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "KHO";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.qlHDB,
            this.qlHDN});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "HÓA ĐƠN";
            // 
            // qlHDB
            // 
            this.qlHDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("qlHDB.ImageOptions.Image")));
            this.qlHDB.Name = "qlHDB";
            this.qlHDB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.qlHDB.Text = "Hóa Đơn Bán";
            this.qlHDB.Click += new System.EventHandler(this.qlHDB_Click);
            // 
            // qlHDN
            // 
            this.qlHDN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("qlHDN.ImageOptions.Image")));
            this.qlHDN.Name = "qlHDN";
            this.qlHDN.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.qlHDN.Text = "Hóa Đơn Nhập";
            // 
            // ControlTaiKhoan
            // 
            this.ControlTaiKhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.DangXuat,
            this.CapTK,
            this.Thoat});
            this.ControlTaiKhoan.Expanded = true;
            this.ControlTaiKhoan.Name = "ControlTaiKhoan";
            this.ControlTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // DangXuat
            // 
            this.DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DangXuat.ImageOptions.Image")));
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DangXuat.Text = "ĐĂNG XUÂT";
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // CapTK
            // 
            this.CapTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CapTK.ImageOptions.Image")));
            this.CapTK.Name = "CapTK";
            this.CapTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CapTK.Text = "CẤP TÀI KHOẢN";
            this.CapTK.Click += new System.EventHandler(this.CapTK_Click);
            // 
            // Thoat
            // 
            this.Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.ImageOptions.Image")));
            this.Thoat.Name = "Thoat";
            this.Thoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Thoat.Text = "THOÁT";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.barEditItem1,
            this.barHeaderItem2,
            this.barHeaderItem3,
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1083, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 0;
            this.barHeaderItem1.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_12_12_143227;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_12_12_143227;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "?";
            this.barHeaderItem2.Id = 2;
            this.barHeaderItem2.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_12_12_143227;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "barHeaderItem3";
            this.barHeaderItem3.Id = 3;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Id = 4;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.barEditItem1,
            this.barHeaderItem2,
            this.barHeaderItem3,
            this.lblTieuDe});
            this.fluentFormDefaultManager1.MaxItemId = 5;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // MainForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 706);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::WindowsFormsApp1.Properties.Resources.Screenshot_2023_12_12_153751;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "TIEN DAT COMPUTER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlDanhMuc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement dmNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement dmKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement dmNCC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Thoat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tkDoanhThu;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator6;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator7;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator8;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator9;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement qlHDB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement qlHDN;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CapTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement qlTTLT;
    }
}