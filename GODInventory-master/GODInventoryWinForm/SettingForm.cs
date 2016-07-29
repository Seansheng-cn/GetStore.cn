using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
            this.installDirTextBox.Text = Properties.Settings.Default.NFWEInstallDir;

        }

        private void saveButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NFWEInstallDir = this.installDirTextBox.Text;
        }

        private void folderBrowserButton1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.installDirTextBox.Text = this.folderBrowserDialog1.SelectedPath; 
            };
        }
    }
}
