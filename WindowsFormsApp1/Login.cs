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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private string placeholderText1 = "Username";
        private string placeholderText2 = "Password";
        public Login()
        {
            InitializeComponent();
            SetPlaceholder();

            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;

            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            btnExit.Click += btnExit_Click;

            this.FormClosing += Form_FormClosing;
            void SetPlaceholder()
            {
                if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtUsername.Text = placeholderText1;
                    txtUsername.ForeColor = System.Drawing.Color.Gray;
                    txtPassword.Text = placeholderText2;
                    txtPassword.ForeColor = System.Drawing.Color.Gray;
                }
            }

            void TextBox_Enter(object sender, EventArgs e)
            {
                if (txtUsername.Text == placeholderText1)
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = System.Drawing.Color.Black;
                }

                if (txtPassword.Text == placeholderText2)
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = System.Drawing.Color.Black;
                }

                if (!chkShowPassword.Checked)
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }

            void TextBox_Leave(object sender, EventArgs e)
            {
                SetPlaceholder();
                if (!chkShowPassword.Checked)
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }

        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        bool IsValidLogin(string username, string password)
        {
            using (var context = new Model1())
            {
                bool isLoginValid = context.TaiKhoans.Any(u => (u.TenNguoiDung == username || u.Email == username ) && u.MatKhau == password);

                return isLoginValid;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsValidLogin(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SendCode sendCode = new SendCode();
            this.Hide();
            sendCode.Show();
        }
    }
}