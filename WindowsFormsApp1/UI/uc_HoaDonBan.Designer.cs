namespace WindowsFormsApp1.UI
{
    partial class uc_HoaDonBan
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.lblTenLT = new System.Windows.Forms.Label();
            this.txtTenLT = new DevExpress.XtraEditors.TextEdit();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.txtTongtien = new DevExpress.XtraEditors.TextEdit();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaLT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbMaKH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbMaNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtNgayban = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcHDB = new DevExpress.XtraGrid.GridControl();
            this.hDBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHMTDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHMTDataSet5 = new WindowsFormsApp1.QLCHMTDataSet5();
            this.gvHDB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDBanTableAdapter1 = new WindowsFormsApp1.QLCHMTDataSet5TableAdapters.HDBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.lblTenLT);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenLT);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoluong);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaHD);
            this.splitContainer1.Panel1.Controls.Add(this.txtTongtien);
            this.splitContainer1.Panel1.Controls.Add(this.txtDongia);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel1.Controls.Add(this.btnInHD);
            this.splitContainer1.Panel1.Controls.Add(this.btnLammoi);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaLT);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaKH);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayban);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcHDB);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 643);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(161, 227);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(157, 22);
            this.txtTenKH.TabIndex = 36;
            // 
            // lblTenLT
            // 
            this.lblTenLT.AutoSize = true;
            this.lblTenLT.Location = new System.Drawing.Point(341, 230);
            this.lblTenLT.Name = "lblTenLT";
            this.lblTenLT.Size = new System.Drawing.Size(76, 16);
            this.lblTenLT.TabIndex = 35;
            this.lblTenLT.Text = "Tên Laptop";
            // 
            // txtTenLT
            // 
            this.txtTenLT.Location = new System.Drawing.Point(433, 222);
            this.txtTenLT.Name = "txtTenLT";
            this.txtTenLT.Properties.ReadOnly = true;
            this.txtTenLT.Size = new System.Drawing.Size(176, 22);
            this.txtTenLT.TabIndex = 34;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(720, 160);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(164, 22);
            this.txtSoluong.TabIndex = 33;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(161, 93);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(157, 22);
            this.txtMaHD.TabIndex = 32;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(720, 222);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(164, 22);
            this.txtTongtien.TabIndex = 31;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(434, 160);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Properties.ReadOnly = true;
            this.txtDongia.Size = new System.Drawing.Size(175, 22);
            this.txtDongia.TabIndex = 30;
            this.txtDongia.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(161, 284);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(164, 22);
            this.txtSDT.TabIndex = 29;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(745, 330);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(126, 23);
            this.btnInHD.TabIndex = 28;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(575, 331);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 27;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(406, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(247, 331);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(101, 331);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // cbMaLT
            // 
            this.cbMaLT.Location = new System.Drawing.Point(433, 99);
            this.cbMaLT.Name = "cbMaLT";
            this.cbMaLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaLT.Size = new System.Drawing.Size(176, 22);
            this.cbMaLT.TabIndex = 23;
            this.cbMaLT.SelectedIndexChanged += new System.EventHandler(this.cbMaLT_SelectedIndexChanged);
            // 
            // cbMaKH
            // 
            this.cbMaKH.Location = new System.Drawing.Point(161, 160);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaKH.Size = new System.Drawing.Size(158, 22);
            this.cbMaKH.TabIndex = 22;
            this.cbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbMaKH_SelectedIndexChanged);
            // 
            // cbMaNV
            // 
            this.cbMaNV.Location = new System.Drawing.Point(719, 100);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaNV.Size = new System.Drawing.Size(158, 22);
            this.cbMaNV.TabIndex = 21;
            // 
            // dtNgayban
            // 
            this.dtNgayban.Location = new System.Drawing.Point(434, 282);
            this.dtNgayban.Name = "dtNgayban";
            this.dtNgayban.Size = new System.Drawing.Size(176, 22);
            this.dtNgayban.TabIndex = 16;
            this.dtNgayban.Value = new System.DateTime(2024, 1, 9, 15, 18, 27, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng Tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "SĐT KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Laptop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn ";
            // 
            // gcHDB
            // 
            this.gcHDB.DataSource = this.hDBanBindingSource1;
            this.gcHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHDB.Location = new System.Drawing.Point(0, 0);
            this.gcHDB.MainView = this.gvHDB;
            this.gcHDB.Name = "gcHDB";
            this.gcHDB.Size = new System.Drawing.Size(1169, 239);
            this.gcHDB.TabIndex = 0;
            this.gcHDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHDB});
            this.gcHDB.Load += new System.EventHandler(this.gcHDB_Load);
            // 
            // hDBanBindingSource1
            // 
            this.hDBanBindingSource1.DataMember = "HDBan";
            this.hDBanBindingSource1.DataSource = this.qLCHMTDataSet5BindingSource;
            // 
            // qLCHMTDataSet5BindingSource
            // 
            this.qLCHMTDataSet5BindingSource.DataSource = this.qLCHMTDataSet5;
            this.qLCHMTDataSet5BindingSource.Position = 0;
            // 
            // qLCHMTDataSet5
            // 
            this.qLCHMTDataSet5.DataSetName = "QLCHMTDataSet5";
            this.qLCHMTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvHDB
            // 
            this.gvHDB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colMaLT,
            this.colTenLT,
            this.colSLBan,
            this.colGiaBan,
            this.colMaNV,
            this.colMaKH,
            this.colTenKH,
            this.colNgayBan,
            this.colTongHD});
            this.gvHDB.GridControl = this.gcHDB;
            this.gvHDB.Name = "gvHDB";
            this.gvHDB.OptionsBehavior.ReadOnly = true;
            this.gvHDB.OptionsView.ShowFooter = true;
            this.gvHDB.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvHDB_FocusedRowChanged);
            // 
            // colMaHD
            // 
            this.colMaHD.FieldName = "MaHD";
            this.colMaHD.MinWidth = 25;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            this.colMaHD.Width = 59;
            // 
            // colMaLT
            // 
            this.colMaLT.FieldName = "MaLT";
            this.colMaLT.MinWidth = 25;
            this.colMaLT.Name = "colMaLT";
            this.colMaLT.Visible = true;
            this.colMaLT.VisibleIndex = 1;
            this.colMaLT.Width = 58;
            // 
            // colTenLT
            // 
            this.colTenLT.FieldName = "TenLT";
            this.colTenLT.MinWidth = 25;
            this.colTenLT.Name = "colTenLT";
            this.colTenLT.Visible = true;
            this.colTenLT.VisibleIndex = 2;
            this.colTenLT.Width = 99;
            // 
            // colSLBan
            // 
            this.colSLBan.FieldName = "SLBan";
            this.colSLBan.MinWidth = 25;
            this.colSLBan.Name = "colSLBan";
            this.colSLBan.Visible = true;
            this.colSLBan.VisibleIndex = 3;
            this.colSLBan.Width = 66;
            // 
            // colGiaBan
            // 
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.MinWidth = 25;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 4;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 5;
            this.colMaNV.Width = 70;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.MinWidth = 25;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 6;
            this.colMaKH.Width = 71;
            // 
            // colTenKH
            // 
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.MinWidth = 25;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 7;
            this.colTenKH.Width = 112;
            // 
            // colNgayBan
            // 
            this.colNgayBan.FieldName = "NgayBan";
            this.colNgayBan.MinWidth = 25;
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.Visible = true;
            this.colNgayBan.VisibleIndex = 8;
            this.colNgayBan.Width = 82;
            // 
            // colTongHD
            // 
            this.colTongHD.FieldName = "TongHD";
            this.colTongHD.MinWidth = 25;
            this.colTongHD.Name = "colTongHD";
            this.colTongHD.Visible = true;
            this.colTongHD.VisibleIndex = 9;
            this.colTongHD.Width = 110;
            // 
            // hDBanBindingSource
            // 
            this.hDBanBindingSource.DataMember = "HDBan";
            // 
            // hDBanTableAdapter1
            // 
            this.hDBanTableAdapter1.ClearBeforeFill = true;
            // 
            // uc_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "uc_HoaDonBan";
            this.Size = new System.Drawing.Size(1169, 643);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayban;
        private DevExpress.XtraEditors.ComboBoxEdit cbMaLT;
        private DevExpress.XtraEditors.ComboBoxEdit cbMaKH;
        private DevExpress.XtraEditors.ComboBoxEdit cbMaNV;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraEditors.TextEdit txtTongtien;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.Label lblTenLT;
        private DevExpress.XtraEditors.TextEdit txtTenLT;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraGrid.GridControl gcHDB;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHDB;
        private System.Windows.Forms.BindingSource hDBanBindingSource;
        private System.Windows.Forms.BindingSource hDBanBindingSource1;
        private System.Windows.Forms.BindingSource qLCHMTDataSet5BindingSource;
        private QLCHMTDataSet5 qLCHMTDataSet5;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSLBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTongHD;
        private QLCHMTDataSet5TableAdapters.HDBanTableAdapter hDBanTableAdapter1;
    }
}
