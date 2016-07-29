using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void SendForm_Shown(object sender, EventArgs e)
        {

            long ecode; 
            Process proc = null;
            try
            {
                proc = new Process();
                proc.StartInfo.FileName = Properties.Settings.Default.NFWEInstallDir;
                proc.StartInfo.Arguments = string.Format("A01");//this is argument
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                ecode = proc.ExitCode;
                
                //lStatus = "起動中"

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }

       }

        private void SendForm_Load(object sender, EventArgs e)
        {

        }
    }
}
