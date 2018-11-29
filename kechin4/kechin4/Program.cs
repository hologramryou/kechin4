using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Diagnostics;

namespace kechin4
{
    static class Program
    {
        public static bool register = false;
        public static bool loging = false;
        public static bool timer = false;
        public static DateTime now = DateTime.Now;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        //Chạy form chính
        static void Main()
        {
            try
            {
                Process.Start("Run.bat");
            }
            catch
            {

            }
            //Kiểm tra tồn tại của user
            if (File.Exists(@"C:\kechin4\user.hlg") == true)
            {
                //Đã đăng ký
                register = true;
            }
            else
            {
                //Tạo directory
                Directory.CreateDirectory(@"C:\kechin4");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Chạy form
            Form signup = new Register();

            //Check register
            while (register == false)
            {
                signup.ShowDialog();
            }
            if (register == true)
            {
                Form signin = new OpenTimer();
                signin.ShowDialog();
            }

            //Check login
            if (loging == true)
            {
                Form main = new Form3();
                main.ShowDialog();
            }

            if (timer == true)
            {
                Form main = new timeform();
                main.ShowDialog();
            }

            if (now.Minute != DateTime.Now.Minute)
            {
                now = DateTime.Now;
            }
        }

        //Tạo user
        public static void FileUserCreate(string user, string pass)
        {
            //Tạo và ghi đè dữ liệu
            string[] data = new string[2];
            data[0] = user;
            data[1] = pass;
            File.Create(@"C:\kechin4\user.hlg").Dispose();
            File.WriteAllLines(@"C:\kechin4\user.hlg", data);
            File.SetAttributes(@"C:\kechin4\user.hlg", FileAttributes.Hidden);

            //Cấp quyền truy cập vào fordel acc
            DirectorySecurity directoryacc = Directory.GetAccessControl(@"C:\Windows\System32");
            directoryacc.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.ReadAndExecute, AccessControlType.Deny));
            Directory.SetAccessControl(@"C:\kechin4", directoryacc);

            //Cấp quyền truy cập vào file acc
            FileSecurity fileaccess = File.GetAccessControl(@"C:\Windows\regedit.exe");
            fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
            File.SetAccessControl(@"C:\kechin4\user.hlg", fileaccess);
        }

        //Kiểm tra truy cập login
        public static void FileUserCheck(string user, string pass)
        {
            string[] data = File.ReadAllLines(@"C:\kechin4\user.hlg");

            //Kiểm tra truy cập của user
            if (data[0] == user & data[1] == pass)
            {
                //Đã login
                loging = true;
            }
            else
            {
                //Chưa login
                loging = false;
            }
        }
    }
}
