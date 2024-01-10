using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class SendCode : Form
    {
        string OTPCode;
        public static string to;

        public SendCode()
        {
            InitializeComponent();
        }
        private bool RangBuoc()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!");
                return false;
            }

            if (!IsEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                return false;
            }
            using (var context = new Model1())
            {
                var user = context.TaiKhoans.FirstOrDefault(u => u.Email == txtEmail.Text);

                if (user == null)
                {
                    MessageBox.Show("Địa chỉ email không liên kết với tài khoản nào!");
                    return false;
                }
            }
            return true;
        }
        bool IsEmailValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            if (RangBuoc() == false)
                return;     
            string from, pass, messageBody;
            Random rand = new Random();
            OTPCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "datbeo183@gmail.com";
            pass = "sfps oztm fcyq trvh";
            messageBody = "OTP của bạn là  " + OTPCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "OTP quên mật khẩu";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Đã gửi OTP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVOTP_Click(object sender, EventArgs e)
        {
            if (OTPCode == (txtOTP.Text).ToString()) 
            {
                to = txtEmail.Text;
                ChangePassword changePassword = new ChangePassword();
                this.Hide();
                changePassword.Show();
            }
            else
            {
                MessageBox.Show("Sai ma OTP");
            }
        }
    }
}
