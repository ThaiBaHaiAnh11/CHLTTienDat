using DevExpress.XtraBars;
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
    public partial class uc_NCC : UserControl
    {
        public uc_NCC()
        {
            InitializeComponent();
        }

        private void uc_NCC_Load_1(object sender, EventArgs e)
        {

            var context = new Model1();
            var NCCsData = context.NCCs.ToList();
                gcNCC.DataSource = NCCsData;
            
        }
        private bool RangBuoc()
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSoNCC.Text == "" || txtEmailNCC.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
                return false;
            }

            return true;
        }
        private bool RangBuoc1()
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Nhà Cung Cấp!");
                return false;
            }

            return true;
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc1() == false)
                return;
            int.TryParse(txtSoNCC.Text, out int soDT);
            var dbContext = new Model1();
            var existingNCC = dbContext.NCCs.FirstOrDefault(k => k.MaNCC == txtMaNCC.Text);

            if (existingNCC != null)
            {
                existingNCC.TenNCC = txtTenNCC.Text;
                existingNCC.SDT = soDT;
                existingNCC.Email = txtEmailNCC.Text;
                dbContext.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                uc_NCC_Load_1(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Nhà cung cấp " + txtMaNCC.Text);
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
                var existingNCC = dbContext.NCCs.FirstOrDefault(k => k.MaNCC == txtMaNCC.Text);

                if (existingNCC != null)
                {
                    dbContext.NCCs.Remove(existingNCC);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa Thành Công");
                    uc_NCC_Load_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Nhà cung cấp cần xóa");
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc() == false)
                return;
            if (!int.TryParse(txtSoNCC.Text, out int soDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }
            var dbContext = new Model1();
            NCC newNCC = new NCC
            {
                MaNCC = txtMaNCC.Text,
                TenNCC = txtTenNCC.Text,
                SDT = soDT,
                Email = txtEmailNCC.Text,
            };
            dbContext.NCCs.Add(newNCC);
            dbContext.SaveChanges();
            MessageBox.Show("Thêm Thành Công");
            uc_NCC_Load_1(sender, e);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtMaNCC.Clear();
            this.txtTenNCC.Clear();
            this.txtSoNCC.Clear();
            this.txtEmailNCC.Clear();
            MessageBox.Show("Đã Xong");
        }

        private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int focusedRowHandle = gvNCC.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                txtMaNCC.Text = gvNCC.GetRowCellValue(focusedRowHandle, "MaNCC").ToString();
                txtTenNCC.Text = gvNCC.GetRowCellValue(focusedRowHandle, "TenNCC").ToString();
                txtSoNCC.Text = gvNCC.GetRowCellValue(focusedRowHandle, "SDT").ToString();
                txtEmailNCC.Text = gvNCC.GetRowCellValue(focusedRowHandle, "Email").ToString();
            }
        }            
    }
}
