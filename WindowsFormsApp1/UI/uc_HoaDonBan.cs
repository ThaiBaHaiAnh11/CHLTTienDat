using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1.UI
{
    public partial class uc_HoaDonBan : UserControl
    {
        public uc_HoaDonBan()
        {
            InitializeComponent();
        }

        private void gcHDB_Load(object sender, EventArgs e)
        {
            var context = new Model1();

            gcHDB.DataSource = null;

            var HDBdata = context.HDBans.ToList();
            gcHDB.DataSource = HDBdata;

            var maNvValues = context.NhanViens.Select(nv => nv.MaNV).Distinct().ToList();
            cbMaNV.Properties.Items.Clear();
            cbMaNV.Properties.Items.AddRange(maNvValues);

            var maKHValues = context.tblKhachHangs.Select(kh => kh.MaKH).Distinct().ToList();
            cbMaKH.Properties.Items.Clear();
            cbMaKH.Properties.Items.AddRange(maKHValues);

            var malTValues = context.ThongTinLTs.Select(lt => lt.MaLT).Distinct().ToList();
            cbMaLT.Properties.Items.Clear();
            cbMaLT.Properties.Items.AddRange(malTValues);

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            this.txtMaHD.Clear();
            this.txtDongia.Clear();
            this.txtSDT.Clear();
            this.txtSoluong.Clear();
            this.txtTongtien.Clear();
            this.txtTenKH.Clear();
            this.txtTongtien.Clear();
            this.cbMaKH.Clear();
            this.cbMaLT.Clear();
            this.cbMaNV.Clear();
            this.txtTenLT.Clear();
            MessageBox.Show("Đã Xong");
        }

        private void cbMaLT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLT.SelectedItem != null)
            {
                string selectedMaLT = cbMaLT.SelectedItem.ToString();
                GetInfoForMaLT(selectedMaLT);
            }
        }
        private void GetInfoForMaLT(string maLT)
        {
            using (Model1 dbContext = new Model1())
            {
                var laptopInfo = dbContext.ThongTinLTs
                    .Where(lt => lt.MaLT == maLT)
                    .Select(lt => new { lt.Gia, lt.TenLT })
                    .FirstOrDefault();
                if (laptopInfo != null)
                {
                    txtDongia.Text = laptopInfo.Gia.ToString();
                    txtTenLT.Text = laptopInfo.TenLT;
                }
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedItem != null)
            {
                string selectedMaKH = cbMaKH.SelectedItem.ToString();
                GetInfoForMaKH(selectedMaKH);
            }
        }
        private void GetInfoForMaKH(string maLT)
        {
            using (Model1 dbContext = new Model1())
            {
                var KHInfo = dbContext.tblKhachHangs
                    .Where(KH => KH.MaKH == maLT)
                    .Select(KH => new { KH.TenKH, KH.SDT })
                    .FirstOrDefault();
                if (KHInfo != null)
                {
                    txtTenKH.Text = KHInfo.TenKH.ToString();
                    txtSDT.Text = KHInfo.SDT.ToString();
                }
            }
        }
        private void UpdateTotalPrice()
        {
            if (double.TryParse(txtDongia.Text, out double donGia) && double.TryParse(txtSoluong.Text, out double soLuong))
            {
                double tongGia = donGia * soLuong;
                txtTongtien.Text = tongGia.ToString();
            }
            else
            {
                txtTongtien.Text = "0";
            }
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private bool RangBuoc()
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(dtNgayban.Text) || string.IsNullOrEmpty(cbMaKH.Text) || string.IsNullOrEmpty(cbMaNV.Text) || string.IsNullOrEmpty(cbMaLT.Text) || string.IsNullOrEmpty(txtTongtien.Text) || string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private bool RangBuoc1()
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (RangBuoc() == false)
                return;
            if (!int.TryParse(txtSoluong.Text, out int SL))
            {
                MessageBox.Show("Số Lượng không hợp lệ.");
                return;
            }
            if (!DateTime.TryParse(dtNgayban.Text, out DateTime ngayBan))
            {
                MessageBox.Show("Ngày bán không hợp lệ.");
                return;
            }
            float.TryParse(txtDongia.Text, out float gia);
            float.TryParse(txtTongtien.Text, out float Tong);


            using (Model1 dbContext = new Model1())
            {
                HDBan newHDB = new HDBan
                {
                    MaHD = txtMaHD.Text,
                    MaLT = cbMaLT.Text,
                    TenLT = txtTenLT.Text,
                    SLBan = SL,
                    GiaBan = gia,
                    MaNV = cbMaNV.Text,
                    MaKH = cbMaKH.Text,
                    TenKH = txtTenKH.Text,
                    NgayBan = ngayBan,
                    TongHD = Tong,

                };
                dbContext.HDBans.Add(newHDB);
                dbContext.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
                gcHDB_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                using (Model1 dbContext = new Model1())
                {
                    var existingHD = dbContext.HDBans.FirstOrDefault(k => k.MaHD == txtMaHD.Text);

                    if (existingHD != null)
                    {
                        dbContext.HDBans.Remove(existingHD);
                        dbContext.SaveChanges();
                        MessageBox.Show("Xóa Thành Công");
                        gcHDB_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Hóa đơn cần xóa có mã:  " + txtMaHD.Text);
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (RangBuoc1() == false)
                return;
            if (!int.TryParse(txtSoluong.Text, out int SL))
            {
                MessageBox.Show("Số Lượng không hợp lệ.");
                return;
            }
            if (!DateTime.TryParse(dtNgayban.Text, out DateTime ngayBan))
            {
                MessageBox.Show("Ngày bán không hợp lệ.");
                return;
            }
            float.TryParse(txtDongia.Text,out float gia);
            float.TryParse(txtTongtien.Text, out float Tong);

            using (Model1 dbContext = new Model1())
            {
                var existingHD = dbContext.HDBans.FirstOrDefault(k => k.MaHD == txtMaHD.Text);

                if (existingHD != null)
                {
                    existingHD.MaHD = txtMaHD.Text;
                    existingHD.MaLT = cbMaLT.Text;
                    existingHD.TenLT = txtTenLT.Text;
                    existingHD.SLBan = SL;
                    existingHD.GiaBan = gia;
                    existingHD.MaNV = cbMaNV.Text;
                    existingHD.MaKH = cbMaKH.Text;
                    existingHD.NgayBan = ngayBan;
                    dbContext.SaveChanges();
                    MessageBox.Show("Sửa Thành Công");
                    gcHDB_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Hóa đơn có Mã: " + txtMaHD.Text);
                }
            }
        }
        private void gvHDB_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var dbContext = new Model1();

            int focusedRowHandle = gvHDB.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                txtMaHD.Text = gvHDB.GetRowCellValue(focusedRowHandle, "MaHD").ToString();
                cbMaNV.Text = gvHDB.GetRowCellValue(focusedRowHandle, "MaNV").ToString();
                cbMaLT.Text = gvHDB.GetRowCellValue(focusedRowHandle, "MaLT").ToString();
                cbMaKH.Text = gvHDB.GetRowCellValue(focusedRowHandle, "MaKH").ToString();
                txtTenLT.Text = gvHDB.GetRowCellValue(focusedRowHandle, "TenLT").ToString();
                txtSoluong.Text = gvHDB.GetRowCellValue(focusedRowHandle, "SLBan").ToString();
                txtDongia.Text = gvHDB.GetRowCellValue(focusedRowHandle, "GiaBan").ToString();
                dtNgayban.Text = gvHDB.GetRowCellValue(focusedRowHandle, "NgayBan").ToString();
                txtTenKH.Text = gvHDB.GetRowCellValue(focusedRowHandle, "TenKH").ToString();
                txtTongtien.Text = gvHDB.GetRowCellValue(focusedRowHandle, "TongHD").ToString();
            }
        }
    }
}
