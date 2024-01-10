using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp1
{
    public partial class ChangePassword : Form
    {
        string username = SendCode.to;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if (newpass.Text == confirmpass.Text)
            {
                using (SqlConnection con = new SqlConnection("Data Source=HAIANH203\\SQLEXPRESS;Initial Catalog=QLCHMT;Integrated Security=True"))
                {
                    string query = "UPDATE TaiKhoan SET MatKhau = @Password WHERE Email = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", confirmpass.Text);
                        cmd.Parameters.AddWithValue("@Username", username);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Mật Khẩu thay đổi thành công!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không đúng hãy thử lại!");
            }
        }

    }

        
}
