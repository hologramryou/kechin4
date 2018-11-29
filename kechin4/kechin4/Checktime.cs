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
    public partial class timeform : Form
    {
        public timeform()
        {
            InitializeComponent();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            try
            {
                File.Create(@"C:\timer.txt").Dispose();
            }
            catch
            {

            }
            string[] time = new string[2];
            time[0] = timein.Text;
            time[1] = timeout.Text;
            File.WriteAllLines(@"C:\timer.txt", time);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeform.ActiveForm.Close();
        }
    }
}
