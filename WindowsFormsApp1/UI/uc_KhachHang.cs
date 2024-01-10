using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.UI
{
    public partial class uc_KhachHang : UserControl
    {
        public uc_KhachHang()
        {
            InitializeComponent();
        }

        private void uc_KhachHang_Load(object sender, EventArgs e)
        {
            var context = new Model1();
            var KhachHangsData = context.tblKhachHangs.ToList();
            gcKH.DataSource = KhachHangsData;
            
            
        }
        private bool RangBuoc()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtDiaChi.Text =="")
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
                return false;
            }

            return true;
        }
        private bool RangBuoc1()
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Khách Hàng!");
                return false;
            }

            return true;
        }

        private void btnSuaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc1() == false)
                return;
            int.TryParse(txtSDT.Text, out int soDT);
            var dbContext = new Model1();
            var existingKH = dbContext.tblKhachHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);

            if (existingKH != null)
            {
                existingKH.TenKH = txtTenKH.Text;
                existingKH.SDT = soDT;
                existingKH.Email = txtEmail.Text;
                existingKH.DiaChi = txtDiaChi.Text;
                dbContext.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                uc_KhachHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khách Hàng " + txtMaKH.Text);
            }
        }

        private void btnXoaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                var dbContext = new Model1();
                var existingKH = dbContext.tblKhachHangs.FirstOrDefault(k => k.MaKH == txtMaKH.Text);

                if (existingKH != null)
                {
                    dbContext.tblKhachHangs.Remove(existingKH);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa Thành Công");
                    uc_KhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Khách Hàng cần xóa");
                }
            }
        }

        private void btnAddKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (RangBuoc() == false)
                return;
            if (!int.TryParse(txtSDT.Text, out int soDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }
            var dbContext = new Model1();
            tblKhachHang newkh = new tblKhachHang
            {
                MaKH = txtMaKH.Text,
                TenKH = txtTenKH.Text,
                SDT = soDT,
                Email = txtEmail.Text,
            };
            dbContext.tblKhachHangs.Add(newkh);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
                uc_KhachHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void gvKH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int focusedRowHandle = gvKH.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                txtMaKH.Text = gvKH.GetRowCellValue(focusedRowHandle, "MaKH").ToString();
                txtTenKH.Text = gvKH.GetRowCellValue(focusedRowHandle, "TenKH").ToString();
                txtSDT.Text = gvKH.GetRowCellValue(focusedRowHandle, "SDT").ToString();
                txtEmail.Text = gvKH.GetRowCellValue(focusedRowHandle, "Email").ToString();
                txtDiaChi.Text = gvKH.GetRowCellValue(focusedRowHandle, "DiaChi").ToString();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtMaKH.Clear();
            this.txtTenKH.Clear();
            this.txtSDT.Clear();
            this.txtEmail.Clear();
            this.txtDiaChi.Clear();
            MessageBox.Show("Đã Xong");
        }
    }
}
