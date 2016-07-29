namespace GODInventoryWinForm.Controls
{
    partial class OrdersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pendingButton = new System.Windows.Forms.Button();
            this.receiveOrderButton = new System.Windows.Forms.Button();
            this.waitToShipButton = new System.Windows.Forms.Button();
            this.shippingOrderButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendingButton
            // 
            this.pendingButton.Location = new System.Drawing.Point(34, 207);
            this.pendingButton.Name = "pendingButton";
            this.pendingButton.Size = new System.Drawing.Size(122, 43);
            this.pendingButton.TabIndex = 0;
            this.pendingButton.Text = "PendingOrders";
            this.pendingButton.UseVisualStyleBackColor = true;
            this.pendingButton.Click += new System.EventHandler(this.pendingButton_Click);
            // 
            // receiveOrderButton
            // 
            this.receiveOrderButton.Enabled = false;
            this.receiveOrderButton.Location = new System.Drawing.Point(34, 73);
            this.receiveOrderButton.Name = "receiveOrderButton";
            this.receiveOrderButton.Size = new System.Drawing.Size(168, 65);
            this.receiveOrderButton.TabIndex = 1;
            this.receiveOrderButton.Text = "Connect Server For New Orders";
            this.receiveOrderButton.UseVisualStyleBackColor = true;
            this.receiveOrderButton.Click += new System.EventHandler(this.receiveOrderButton_Click);
            // 
            // waitToShipButton
            // 
            this.waitToShipButton.Location = new System.Drawing.Point(199, 207);
            this.waitToShipButton.Name = "waitToShipButton";
            this.waitToShipButton.Size = new System.Drawing.Size(122, 43);
            this.waitToShipButton.TabIndex = 4;
            this.waitToShipButton.Text = "WaitForShip";
            this.waitToShipButton.UseVisualStyleBackColor = true;
            this.waitToShipButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // shippingOrderButton
            // 
            this.shippingOrderButton.Location = new System.Drawing.Point(365, 207);
            this.shippingOrderButton.Name = "shippingOrderButton";
            this.shippingOrderButton.Size = new System.Drawing.Size(122, 43);
            this.shippingOrderButton.TabIndex = 5;
            this.shippingOrderButton.Text = "ShippingOrders";
            this.shippingOrderButton.UseVisualStyleBackColor = true;
            this.shippingOrderButton.Click += new System.EventHandler(this.shippedOrderButton_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(199, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 43);
            this.button6.TabIndex = 0;
            this.button6.Text = "OrderHistory";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "->";
            // 
            // orderConfirmButton
            // 
            this.orderConfirmButton.Enabled = false;
            this.orderConfirmButton.Location = new System.Drawing.Point(319, 73);
            this.orderConfirmButton.Name = "orderConfirmButton";
            this.orderConfirmButton.Size = new System.Drawing.Size(168, 65);
            this.orderConfirmButton.TabIndex = 10;
            this.orderConfirmButton.Text = "Connect Server For Order Confirm";
            this.orderConfirmButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "|\r\n|\r\nV";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "|\r\n|\r\nV";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Controls.Add(this.button6);
            this.contentPanel.Controls.Add(this.orderConfirmButton);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.pendingButton);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.receiveOrderButton);
            this.contentPanel.Controls.Add(this.waitToShipButton);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.shippingOrderButton);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Location = new System.Drawing.Point(86, 36);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(523, 374);
            this.contentPanel.TabIndex = 13;
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.contentPanel);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(698, 450);
            this.Load += new System.EventHandler(this.OrdersControl_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.OrdersControl_ControlRemoved);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OrdersControl_Paint);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pendingButton;
        private System.Windows.Forms.Button receiveOrderButton;
        private System.Windows.Forms.Button waitToShipButton;
        private System.Windows.Forms.Button shippingOrderButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel contentPanel;
    }
}
