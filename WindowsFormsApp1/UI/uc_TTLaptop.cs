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
    public partial class uc_TTLaptop : UserControl
    {
        public uc_TTLaptop()
        {
            InitializeComponent();
        }

        private void uc_TTLaptop_Load(object sender, EventArgs e)
        {
            var context = new Model1();
            var ttlt = context.ThongTinLTs.ToList();
            gcTTLT.DataSource = ttlt;
            var maNCCValues = context.NCCs.Select(ncc => ncc.MaNCC).Distinct().ToList();
            cbMaNCC.Properties.Items.Clear(); 
            cbMaNCC.Properties.Items.AddRange(maNCCValues);
            
        }
        private bool RangBuoc()
        {
            if ( txtMaLT.Text ==""|| txtTenLT.Text == "" || txtGiaBan.Text == "" || txtSL.Text == "" || txtXuatXu.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin !");
                return false;
            }

            return true;
        }
        private bool RangBuoc1()
        {
            if (txtMaLT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Laptop!");
                return false;
            }

            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc() == false)
                return;
            if (!int.TryParse(txtGiaBan.Text, out int giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                return;
            }
            if (!int.TryParse(txtSL.Text, out int SL))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }
            var dbContext = new Model1();
            ThongTinLT newlt = new ThongTinLT
            {
                MaLT = txtMaLT.Text,
                TenLT = txtTenLT.Text,
                XuatXu = txtXuatXu.Text,
                Gia = giaBan,
                SoLuong = SL
            };
            dbContext.ThongTinLTs.Add(newlt);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
                uc_TTLaptop_Load(sender, e);
                txtMaLT.Text = newlt.MaLT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RangBuoc1() == false)
                return;
            if (!int.TryParse(txtGiaBan.Text, out int giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                return;
            }
            if (!int.TryParse(txtSL.Text, out int SL))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            var dbContext = new Model1();
            var existingTTLT = dbContext.ThongTinLTs.FirstOrDefault(k => k.MaLT == txtMaLT.Text);

            if (existingTTLT != null)
            {
                existingTTLT.TenLT = txtTenLT.Text;
                existingTTLT.XuatXu = txtXuatXu.Text;
                existingTTLT.MaNCC = cbMaNCC.Text;
                existingTTLT.Gia = giaBan;
                existingTTLT.SoLuong = SL;
                dbContext.SaveChanges();
                MessageBox.Show("Sửa Thành Công");
                uc_TTLaptop_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Laptop " + txtMaLT.Text);
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
                var existingTTLT = dbContext.ThongTinLTs.FirstOrDefault(k => k.MaLT == txtMaLT.Text);

                if (existingTTLT != null)
                {
                    dbContext.ThongTinLTs.Remove(existingTTLT);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa Thành Công");
                    uc_TTLaptop_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy laptop cần xóa");
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.txtMaLT.Clear();
            this.txtTenLT.Clear();
            this.txtGiaBan.Clear();
            this.txtXuatXu.Clear();
            this.txtSL.Clear();
            MessageBox.Show("Đã Xong");
        }

        private void gvTTLT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            int focusedRowHandle = gvTTLT.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                txtMaLT.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "MaLT").ToString();
                txtTenLT.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "TenLT").ToString();
                txtGiaBan.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "Gia").ToString();
                txtXuatXu.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "XuatXu").ToString();
                txtSL.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "SoLuong").ToString();
                cbMaNCC.Text = gvTTLT.GetRowCellValue(focusedRowHandle, "MaNCC").ToString();
            }
        }
    }
}
