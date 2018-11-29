using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kechin4
{
    public partial class OpenTimer : Form
    {
        public OpenTimer()
        {
            InitializeComponent();

            //Chạy trình chuyên gia
            userlogin.AutoCompleteMode = AutoCompleteMode.Suggest;
            userlogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            userlogin.AutoCompleteCustomSource.Add(File.ReadAllLines(@"C:\kechin4\user.hlg")[0]);
        }

        //Nút đăng nhập
        private void Signin_Click(object sender, EventArgs e)
        {
            Program.FileUserCheck(userlogin.Text, pass.Text);
            if (Program.loging == false)
            {
                MessageBox.Show("Không thể truy cập vào tài khoản!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.loging = true;
                OpenTimer.ActiveForm.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenTimer.ActiveForm.Close();
        }
    }
}
