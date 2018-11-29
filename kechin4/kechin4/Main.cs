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
using System.Security.AccessControl;

namespace kechin4
{
    public partial class Form3 : Form
    {
        public string[] site = new string[1024];
        public bool save = false;

        public Form3()
        {
            InitializeComponent();
        }

        //Void của nút chặn
        private void Check(object sender, EventArgs e)
        {
            //Điều kiện để chạy chặn là file không cần phải lưu
            if (save == true)
            {
                //Khai báo file
                FileSecurity fileaccess = File.GetAccessControl(@"C:\Windows\System32");
                fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
                File.SetAccessControl(@"C:\Windows\System32\drivers\etc\hosts", fileaccess);

                //Lưu file host
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                File.Create(@"C:\hosts").Dispose();
                File.WriteAllLines(@"C:\hosts", site);
                File.Copy(@"C:\hosts", @"C:\Windows\System32\drivers\etc\hosts");

                //Chọn quyền cho file host
                fileaccess = File.GetAccessControl(@"C:\Windows\regedit.exe");
                fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
                File.SetAccessControl(@"C:\Windows\System32\drivers\etc\hosts", fileaccess);

                //In ra khi chặn thành công
                MessageBox.Show("Bạn đã chặn web!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //In ra khi chưa lưu tài nguyên
                MessageBox.Show("Bạn chưa lưu lại tài nguyên!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //Void của nút Lưu
        private void Save(object sender, EventArgs e)
        {
            //Tạo ô thoại để lưu mới tệp
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt|hologramEDIT|*.hlg|All Files|*";
            saveFileDialog1.Title = "Lưu mới tệp";
            saveFileDialog1.ShowDialog();

            //Check file path để chặn
            if (saveFileDialog1.FileName != "")
            {
                //Lưu lại file
                for (int i = 0; i < Site2check.Lines.Count(); i += 1)
                {
                    site[i] = "127.0.0.1 " + Site2check.Lines[i];
                }
                File.Create(saveFileDialog1.FileName).Dispose();
                File.WriteAllLines(saveFileDialog1.FileName, Site2check.Lines);

                //In ra khi lưu thành công tài nguyên
                MessageBox.Show("Bạn đã lưu lại tài nguyên!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Không cần phải Lưu
                save = true;
            }

            //Thay direct
            direct.Text = saveFileDialog1.FileName;
        }

        //Xảy ra khi ấn vào path textbox
        private void OpenImport(object sender, EventArgs e)
        {
            //Tạo ô thoại để mở
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Text file|*.txt|hologramEDIT|*.hlg|All Files|*";
            opendialog.Title = "Chọn tệp";
            opendialog.ShowDialog();

            //Gán cho path textbox bằng file path
            direct.Text = opendialog.FileName;

            //Import chữ
            try
            {
                //Import asset
                Site2check.Text = File.ReadAllText(direct.Text);
                MessageBox.Show("Bạn đã nhập tài nguyên!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Không cần phải Lưu
                save = true;
            }
            catch
            {
                //In ra khi chưa có tài nguyên
                MessageBox.Show("Bạn chưa chọn tài nguyên chặn!", "kechin4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Xảy ra khi ấn vào site2web textbox
        private void Check_the_box(object sender, EventArgs e)
        {
            //Cần phải Lưu
            save = false;
        }

        //Sự kiện xảy ra khi ấn nút Open
        private void Open_Click(object sender, EventArgs e)
        {
            Form main = new timeform();
            main.ShowDialog();
        }

        //Đóng ứng dụng khi nhấn vào label
        private void label1_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }
    }
}
