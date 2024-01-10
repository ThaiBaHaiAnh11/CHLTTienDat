using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        uc_NhanVien ucNhanVien;
        uc_NCC ucNCC;
        uc_KhachHang ucKhachHang;
        uc_CapTK uccaptk;
        uc_HoaDonBan ucHoaDonBan;
        uc_TTLaptop ucTTLT;
        uc_DoanhThu ucDoanThu;
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void dmNhanVien_Click(object sender, EventArgs e)
        {
            if (ucNhanVien == null)
            {
                ucNhanVien = new uc_NhanVien();
                ucNhanVien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucNhanVien);
                ucNhanVien.BringToFront();
            }
            else
                ucNhanVien.BringToFront();
            lblTieuDe.Caption = dmNhanVien.Text;
        }

        private void dmKhachHang_Click(object sender, EventArgs e)
        {
            if (ucKhachHang == null)
            {
                ucKhachHang = new uc_KhachHang();
                ucKhachHang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucKhachHang);
                ucKhachHang.BringToFront();
            }
            else
                ucKhachHang.BringToFront();
            lblTieuDe.Caption = dmKhachHang.Text;

        }

        private void dmNCC_Click(object sender, EventArgs e)
        {
            if (ucNCC == null)
            {
                ucNCC = new uc_NCC();
                ucNCC.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucNCC);
                ucNCC.BringToFront();
            }
            else
                ucNCC.BringToFront();
            lblTieuDe.Caption = dmNCC.Text;
        }
        private void CapTK_Click(object sender, EventArgs e)
        {
            uccaptk = new uc_CapTK();
            uccaptk.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(uccaptk);
            uccaptk.BringToFront();
            lblTieuDe.Caption = CapTK.Text;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void qlHDB_Click(object sender, EventArgs e)
        {
            ucHoaDonBan = new uc_HoaDonBan();
            ucHoaDonBan.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(ucHoaDonBan);
            ucHoaDonBan.BringToFront();
            lblTieuDe.Caption = qlHDB.Text;
        }

        private void qlTTLT_Click(object sender, EventArgs e)
        {
            ucTTLT = new uc_TTLaptop();
            ucTTLT.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(ucTTLT);
            ucTTLT.BringToFront();
            lblTieuDe.Caption = qlTTLT.Text;
        }

        private void ControlThongKe_Click(object sender, EventArgs e)
        {

        }

        private void tkDoanhThu_Click(object sender, EventArgs e)
        {
            ucDoanThu = new uc_DoanhThu();
            ucDoanThu.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(ucDoanThu);
            ucDoanThu.BringToFront();
            lblTieuDe.Caption = ucDoanThu.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn Thoát chương trình ?", "Xác nhận", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
