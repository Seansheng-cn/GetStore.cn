namespace GODInventoryWinForm
{
    partial class GenerateASNTextForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderCountTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.entityDataSource1 = new GODInventory.ViewModel.EntityDataSource(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "NYOTEI Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathTextBox1
            // 
            this.pathTextBox1.Location = new System.Drawing.Point(125, 59);
            this.pathTextBox1.Name = "pathTextBox1";
            this.pathTextBox1.ReadOnly = true;
            this.pathTextBox1.Size = new System.Drawing.Size(428, 21);
            this.pathTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Count";
            // 
            // orderCountTextBox
            // 
            this.orderCountTextBox.Location = new System.Drawing.Point(125, 122);
            this.orderCountTextBox.Name = "orderCountTextBox";
            this.orderCountTextBox.Size = new System.Drawing.Size(428, 21);
            this.orderCountTextBox.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(373, 195);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleButton.Location = new System.Drawing.Point(478, 194);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 23);
            this.cancleButton.TabIndex = 6;
            this.cancleButton.Text = "Cancel";
            this.cancleButton.UseVisualStyleBackColor = true;
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GODInventory.MyLinq.GODDbContext);
            // 
            // GenerateASNTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 262);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.orderCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTextBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateASNTextForm";
            this.Text = "ExportOrderTextForm";
            this.Load += new System.EventHandler(this.ExportOrderTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderCountTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancleButton;
        private GODInventory.ViewModel.EntityDataSource entityDataSource1;
    }
}