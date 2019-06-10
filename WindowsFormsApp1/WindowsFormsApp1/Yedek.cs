using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Yedek : Form
    {
        public Yedek()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            int year = Time.Year;
            int month = Time.Month;
            int day = Time.Day;
            int hour = Time.Hour;
            int min = Time.Minute;
            int second = Time.Second;
            int millisecond = Time.Millisecond;

            string path = "C:/";
            path = path + day + "-" + month + "-" + year + "-" + hour + "-" + min + "-" + second + "-" + millisecond;

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:/oraclexe/app/oracle/product/11.2.0/server/bin/exp.exe";
            psi.RedirectStandardInput = false;
            psi.RedirectStandardOutput = true;
            //psi.Arguments = string.Format("USERID=test/test  FULL=y FILE=" + path + ".dmp CONSISTENT=y GRANTS=y BUFFER=100000 rows = Yes");
            psi.Arguments = string.Format("USERID=ADAM@//localhost:1521/xe  FILE=" + path + ".dmp TABLES=(t)");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.WaitForExit();
            process.Close();
            MessageBox.Show("Oldu");


        }
    }
}
