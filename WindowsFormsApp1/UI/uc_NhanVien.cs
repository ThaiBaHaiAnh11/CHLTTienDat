using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.UI
{
    public partial class uc_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_NhanVien()
        {
            InitializeComponent();
        }

        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            var context = new Model1();
            var nhanViensData = context.NhanViens.ToList();
            gcDanhSach.DataSource = nhanViensData;
            
        }

        private bool RangBuoc()
        {
            if (txtMaNhanVien.Text == "" || txtTenNV.Text == "" || txtGT.Text == "" || txtSoDT.Text == "" || txtDC.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
                return false;
            }

            return true;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc() == false)
                return;
            if (!int.TryParse(txtSoDT.Text, out int soDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }
            var dbContext = new Model1();
            NhanVien newNhanVien = new NhanVien
            {
                MaNV = txtMaNhanVien.Text,
                HoTen = txtTenNV.Text,
                GioiTinh = txtGT.Text,
                SDT = soDT,
                DiaChi = txtDC.Text,
             };
            dbContext.NhanViens.Add(newNhanVien);
            dbContext.SaveChanges();
            MessageBox.Show("Thêm Thành Công");
            uc_NhanVien_Load(sender, e);
        }

        private bool RangBuoc1()
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Nhân Viên!");
                return false;
            }

            return true;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc1() == false)
                return;
            int.TryParse(txtSoDT.Text, out int soDT);
            var dbContext = new Model1();
            var existingNhanVien = dbContext.NhanViens.FirstOrDefault(k => k.MaNV == txtMaNhanVien.Text);

            if (existingNhanVien != null)
            {
                existingNhanVien.HoTen = txtTenNV.Text;
                existingNhanVien.GioiTinh = txtGT.Text;
                existingNhanVien.SDT = soDT;
                existingNhanVien.DiaChi = txtDC.Text;

                dbContext.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                uc_NhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có MaNV = " + txtMaNhanVien.Text);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var dbContext = new Model1();
                var existingNhanVien = dbContext.NhanViens.FirstOrDefault(k => k.MaNV == txtMaNhanVien.Text);

                if (existingNhanVien != null)
                {
                    dbContext.NhanViens.Remove(existingNhanVien);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa Thành Công");
                    uc_NhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có MaNV cần xóa " + txtTenNV.Text);
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtMaNhanVien.Clear();
            this.txtDC.Clear();
            this.txtGT.Clear();
            this.txtSoDT.Clear();
            this.txtTenNV.Clear();
            MessageBox.Show("Đã Xong");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                txtMaNhanVien.Text = gridView1.GetRowCellValue(focusedRowHandle, "MaNV").ToString();
                txtTenNV.Text = gridView1.GetRowCellValue(focusedRowHandle, "HoTen").ToString();
                txtGT.Text = gridView1.GetRowCellValue(focusedRowHandle, "GioiTinh").ToString();
                txtSoDT.Text = gridView1.GetRowCellValue(focusedRowHandle, "SDT").ToString();
                txtDC.Text = gridView1.GetRowCellValue(focusedRowHandle, "DiaChi").ToString();
            }
        }

    }
}
