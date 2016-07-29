namespace GODInventoryWinForm.Controls
{
    partial class StoresControl
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.店番DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店名カナDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送担当DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.郵便番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.県別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.県内エリアDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAX番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entityDataSource1 = new GODInventory.ViewModel.EntityDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.店番DataGridViewTextBoxColumn,
            this.店名DataGridViewTextBoxColumn,
            this.店名カナDataGridViewTextBoxColumn,
            this.配送担当DataGridViewTextBoxColumn,
            this.郵便番号DataGridViewTextBoxColumn,
            this.県別DataGridViewTextBoxColumn,
            this.県内エリアDataGridViewTextBoxColumn,
            this.住所DataGridViewTextBoxColumn,
            this.電話番号DataGridViewTextBoxColumn,
            this.fAX番号DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(632, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // 店番DataGridViewTextBoxColumn
            // 
            this.店番DataGridViewTextBoxColumn.DataPropertyName = "店番";
            this.店番DataGridViewTextBoxColumn.HeaderText = "店番";
            this.店番DataGridViewTextBoxColumn.Name = "店番DataGridViewTextBoxColumn";
            // 
            // 店名DataGridViewTextBoxColumn
            // 
            this.店名DataGridViewTextBoxColumn.DataPropertyName = "店名";
            this.店名DataGridViewTextBoxColumn.HeaderText = "店名";
            this.店名DataGridViewTextBoxColumn.Name = "店名DataGridViewTextBoxColumn";
            // 
            // 店名カナDataGridViewTextBoxColumn
            // 
            this.店名カナDataGridViewTextBoxColumn.DataPropertyName = "店名カナ";
            this.店名カナDataGridViewTextBoxColumn.HeaderText = "店名カナ";
            this.店名カナDataGridViewTextBoxColumn.Name = "店名カナDataGridViewTextBoxColumn";
            // 
            // 配送担当DataGridViewTextBoxColumn
            // 
            this.配送担当DataGridViewTextBoxColumn.DataPropertyName = "配送担当";
            this.配送担当DataGridViewTextBoxColumn.HeaderText = "配送担当";
            this.配送担当DataGridViewTextBoxColumn.Name = "配送担当DataGridViewTextBoxColumn";
            // 
            // 郵便番号DataGridViewTextBoxColumn
            // 
            this.郵便番号DataGridViewTextBoxColumn.DataPropertyName = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.HeaderText = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.Name = "郵便番号DataGridViewTextBoxColumn";
            // 
            // 県別DataGridViewTextBoxColumn
            // 
            this.県別DataGridViewTextBoxColumn.DataPropertyName = "県別";
            this.県別DataGridViewTextBoxColumn.HeaderText = "県別";
            this.県別DataGridViewTextBoxColumn.Name = "県別DataGridViewTextBoxColumn";
            // 
            // 県内エリアDataGridViewTextBoxColumn
            // 
            this.県内エリアDataGridViewTextBoxColumn.DataPropertyName = "県内エリア";
            this.県内エリアDataGridViewTextBoxColumn.HeaderText = "県内エリア";
            this.県内エリアDataGridViewTextBoxColumn.Name = "県内エリアDataGridViewTextBoxColumn";
            // 
            // 住所DataGridViewTextBoxColumn
            // 
            this.住所DataGridViewTextBoxColumn.DataPropertyName = "住所";
            this.住所DataGridViewTextBoxColumn.HeaderText = "住所";
            this.住所DataGridViewTextBoxColumn.Name = "住所DataGridViewTextBoxColumn";
            // 
            // 電話番号DataGridViewTextBoxColumn
            // 
            this.電話番号DataGridViewTextBoxColumn.DataPropertyName = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.HeaderText = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.Name = "電話番号DataGridViewTextBoxColumn";
            // 
            // fAX番号DataGridViewTextBoxColumn
            // 
            this.fAX番号DataGridViewTextBoxColumn.DataPropertyName = "FAX番号";
            this.fAX番号DataGridViewTextBoxColumn.HeaderText = "FAX番号";
            this.fAX番号DataGridViewTextBoxColumn.Name = "fAX番号DataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "t_shoplist";
            this.bindingSource1.DataSource = this.entityDataSource1;
            this.bindingSource1.Filter = global::GODInventoryWinForm.Properties.Resources.String1;
            this.bindingSource1.Position = 0;
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GODInventory.MyLinq.GODDbContext);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 308);
            this.panel1.TabIndex = 1;
            // 
            // StoresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StoresControl";
            this.Size = new System.Drawing.Size(635, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private GODInventory.ViewModel.EntityDataSource entityDataSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店番DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店名カナDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送担当DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 県別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 県内エリアDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAX番号DataGridViewTextBoxColumn;
    }
}
