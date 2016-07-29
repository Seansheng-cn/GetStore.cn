namespace GODInventoryWinForm
{
    partial class ReceiveForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.okButton1 = new System.Windows.Forms.Button();
            this.processMsgLabel2 = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ナフコEDI受信処理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton1
            // 
            this.okButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Location = new System.Drawing.Point(185, 155);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 23);
            this.okButton1.TabIndex = 1;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            // 
            // processMsgLabel2
            // 
            this.processMsgLabel2.Location = new System.Drawing.Point(3, 69);
            this.processMsgLabel2.Name = "processMsgLabel2";
            this.processMsgLabel2.Size = new System.Drawing.Size(441, 21);
            this.processMsgLabel2.TabIndex = 2;
            this.processMsgLabel2.Text = "起動中";
            this.processMsgLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgLabel
            // 
            this.msgLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.msgLabel.Location = new System.Drawing.Point(5, 98);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(441, 38);
            this.msgLabel.TabIndex = 3;
            this.msgLabel.Text = "Message";
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 205);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.processMsgLabel2);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiveForm";
            this.Text = "ReceiveForm";
            this.Shown += new System.EventHandler(this.ReceiveForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton1;
        private System.Windows.Forms.Label processMsgLabel2;
        private System.Windows.Forms.Label msgLabel;
    }
}