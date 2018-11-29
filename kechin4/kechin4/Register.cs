using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kechin4
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        //Nút tạo tài khoản
        private void button1_Click(object sender, EventArgs e)
        {
            //Check điều kiện để có thể tạo tài khoản
            if (repass.Text == pass.Text)
            {
                //Tạo file
                Program.FileUserCreate(user.Text, pass.Text);

                //Chứng nhận đã đăng kí
                Program.register = true;
                Register.ActiveForm.Close();
            }
            else
            {
                //In ra nếu repass != pass
                MessageBox.Show("Mật khẩu chưa đúng!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register.ActiveForm.Close();
        }
    }
}
