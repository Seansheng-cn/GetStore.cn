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
    public partial class OrdersControl : UserControl
    {
        private PendingOrderForm pendingOrderForm;
        private WaitToShipForm waitToShipOrderForm;
        private ShippingOrderForm shippingOrderForm;

        public OrdersControl()
        {
            InitializeComponent();
            this.pendingOrderForm = new PendingOrderForm();
            this.waitToShipOrderForm = new WaitToShipForm();
            this.shippingOrderForm = new ShippingOrderForm();
            this.Disposed += new EventHandler(OrdersControl_Disposed);
            
        }


        private void pendingButton_Click(object sender, EventArgs e)
        {
            AdjustSubformSize(pendingOrderForm);
            pendingOrderForm.RefreshPager();
            pendingOrderForm.ShowDialog(  );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdjustSubformSize(waitToShipOrderForm);
            // 显示之前重新加载数据，订单数据可能已更新。
            waitToShipOrderForm.RefreshPager();
            waitToShipOrderForm.ShowDialog();

        }

        private void shippedOrderButton_Click(object sender, EventArgs e)
        {
            AdjustSubformSize(shippingOrderForm);
            shippingOrderForm.RefreshPager();
            shippingOrderForm.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void OrdersControl_Load(object sender, EventArgs e)
        {
//            Console.WriteLine(" orders control demension {0}, {1}", this.Width, this.Height);
//            contentPanel.Left = (this.Width - contentPanel.Width) / 2;
//            contentPanel.Top = (this.Height - contentPanel.Height) / 2;
//            Console.WriteLine(" orders control demension {0}, {1}", contentPanel.Left, contentPanel.Top );
        }

        private void OrdersControl_Paint(object sender, PaintEventArgs e)
        {
            contentPanel.Left = (this.Width - contentPanel.Width) / 2;
            contentPanel.Top = (this.Height - contentPanel.Height) / 2;

        }


        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            new ReceiveForm().ShowDialog();
        }



        private void AdjustSubformSize(Form form) {
            var size = this.Parent.Size;
            size.Height = size.Height - 100;
            size.Width = size.Width - 50;
            form.Size = size;
        }

        private void OrdersControl_ControlRemoved(object sender, ControlEventArgs e)
        {
        }


        //Fix error 卸载 Appdomain 时出错
        void OrdersControl_Disposed(object sender, EventArgs e)
        {
            this.pendingOrderForm.Dispose();
            this.waitToShipOrderForm.Dispose();
            this.shippingOrderForm.Dispose();
        }
    }
}
