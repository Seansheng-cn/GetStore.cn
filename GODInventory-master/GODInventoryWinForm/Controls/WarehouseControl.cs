using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm.Controls
{
    public partial class WarehouseControl : UserControl
    {
        public WarehouseControl()
        {
            InitializeComponent();
        }

        private void WarehouseControl_Paint(object sender, PaintEventArgs e)
        {
            contentPanel.Left = (this.Width - contentPanel.Width) / 2;
            contentPanel.Top = (this.Height - contentPanel.Height) / 2;

        }
    }
}
