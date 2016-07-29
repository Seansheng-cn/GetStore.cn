using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm
{
    using GODInventoryWinForm.Controls;

    public partial class MainForm : Form
    {
        private ProductsControl products_control;
        private OrdersControl orders_control;
        private MainControl mainControl;
        private StoresControl storesControl;
        private WarehouseControl warehouseControl;

        public MainForm()
        {
            InitializeComponent();
            InitUserControls();
        }

        private void InitUserControls() {
            mainControl = new MainControl();
            mainControl.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(mainControl);

            products_control = new ProductsControl();
            products_control.Dock = DockStyle.Fill;

            orders_control = new OrdersControl();
            orders_control.Dock = DockStyle.Fill;

            storesControl = new StoresControl();
            storesControl.Dock = DockStyle.Fill;

            warehouseControl = new WarehouseControl();
            warehouseControl.Dock = DockStyle.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(orders_control );

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(products_control);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(mainControl);
        }

        private void warehouseToolStripButton_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(warehouseControl);
        }

        private void customerToolStripButton_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(storesControl);
        }

        private void settingToolStripButton_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
            
        }

        private void importOrderTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImportOrderTextForm().ShowDialog();
        }

        private void exportASNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerateASNTextForm().ShowDialog();
        }

        private void importReceivedOrderTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImportReceivedTextForm().ShowDialog();
        }
    }
}
