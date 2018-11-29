using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Configuration.Install;
using System.Security.AccessControl;

namespace FirstWindowsService
{
    public partial class Service1 : ServiceBase
    {
        //Tạo 1 biến Timer private
        private Timer timer = null;

        public Service1()
        {
            InitializeComponent();
        }
        
        protected override void OnStart(string[] args)
        {
            //Tạo 1 timer
            timer = new Timer();
            //Execute mỗi 1s
            timer.Interval = 1000;
            //Gắn thêm sự kiện mỗi time tick
            timer.Elapsed += timer_Tick;
            //Enable timer
            timer.Enabled = true;
        }

        //Sự kiện xảy ra mỗi time tick
        private void timer_Tick(object sender, ElapsedEventArgs args)
        {
            //Đọc dữ liệu về thời gian
            string[] timecheck = File.ReadAllLines(@"C:\timer.txt");

            //Nếu lớn hơn khoảng time in thì sẽ tạo ra file host
            if (int.Parse(timecheck[0].Remove(2, 3)) < DateTime.Now.Hour || int.Parse(timecheck[0].Remove(2, 3)) == DateTime.Now.Hour & int.Parse(timecheck[0].Remove(0, 3)) < DateTime.Now.Minute)
            {
                if (int.Parse(timecheck[1].Remove(2, 3)) < DateTime.Now.Hour || int.Parse(timecheck[1].Remove(2, 3)) == DateTime.Now.Hour & int.Parse(timecheck[1].Remove(0, 3)) < DateTime.Now.Minute || int.Parse(timecheck[0].Remove(2, 3)) > DateTime.Now.Hour || int.Parse(timecheck[0].Remove(2, 3)) == DateTime.Now.Hour & int.Parse(timecheck[1].Remove(0, 3)) > DateTime.Now.Minute)
                {
                    if (File.Exists(@"C:\Windows\System32\drivers\etc\hosts") == true)
                    {
                        FileSecurity fileaccess = File.GetAccessControl(@"C:\Windows\System32");
                        fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
                        File.SetAccessControl(@"C:\Windows\System32\drivers\etc\hosts", fileaccess);
                        File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                    }
                }
                else
                {
                    FileSecurity fileaccess = File.GetAccessControl(@"C:\Windows\System32");
                    fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
                    if (File.Exists(@"C:\Windows\System32\drivers\etc\hosts") == true)
                    {
                        File.SetAccessControl(@"C:\Windows\System32\drivers\etc\hosts", fileaccess);
                        File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                    }
                    File.Copy(@"C:\hosts", @"C:\Windows\System32\drivers\etc\hosts");
                }
            }
            if (int.Parse(timecheck[1].Remove(2, 3)) < DateTime.Now.Hour || int.Parse(timecheck[1].Remove(2, 3)) == DateTime.Now.Hour & int.Parse(timecheck[1].Remove(0, 3)) < DateTime.Now.Minute || int.Parse(timecheck[0].Remove(2, 3)) > DateTime.Now.Hour || int.Parse(timecheck[0].Remove(2, 3)) == DateTime.Now.Hour & int.Parse(timecheck[1].Remove(0, 3)) > DateTime.Now.Minute)
            {
                FileSecurity fileaccess = File.GetAccessControl(@"C:\Windows\System32");
                fileaccess.AddAccessRule(new FileSystemAccessRule(@"Users", FileSystemRights.Read, AccessControlType.Allow));
                File.SetAccessControl(@"C:\Windows\System32\drivers\etc\hosts", fileaccess);
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            }
        }


        protected override void OnStop()
        {
            timer.Enabled = true;
        }
    }
}
