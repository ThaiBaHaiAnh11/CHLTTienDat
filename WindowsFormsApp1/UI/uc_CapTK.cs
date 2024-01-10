using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.UI
{
    public partial class uc_CapTK : UserControl
    {
        public uc_CapTK()
        {
            InitializeComponent();
        }
        private readonly Model1 dbContext = new Model1();

        bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string confirmPassword = txtconfirmPassword.Text;
            string hoTen = txtHoTen.Text;
            string maNhanVien = txtMaNV.Text;


            try
            {
                if (dbContext.TaiKhoans.Any(u => u.TenNguoiDung == username))
                {
                    MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TaiKhoan taiKhoan = new TaiKhoan
                {
                    TenNguoiDung = username,
                    MatKhau = password,
                    Email = email,
                    HoTen = hoTen,
                    MaNV = maNhanVien
                };

                dbContext.TaiKhoans.Add(taiKhoan);

                int rowsAffected = dbContext.SaveChanges();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCapCha.Text == txtCapCha.Text)
            {
                MessageBox.Show("Mã CapCha Đúng");
            }
            else
            {
                MessageBox.Show("Capcha Sai! Hãy Nhập Lại");
                this.OnLoad(e);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();
            int num = random.Next(6, 8);
            string captcha = "";
            int total = 0;

            do
            {
                int chr = random.Next(48, 123);

                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;

                    if (total == num)
                        break;
                }
            } while (true);

            lbcapcha.Text = captcha;
        }
    }
}