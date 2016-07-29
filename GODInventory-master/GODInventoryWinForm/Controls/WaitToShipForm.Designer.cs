namespace GODInventoryWinForm.Controls
{
    partial class WaitToShipForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shipperComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pager1 = new GODInventoryWinForm.Controls.Pager();
            this.entityDataSource1 = new GODInventory.ViewModel.EntityDataSource(this.components);
            this.受注日Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ジャンルColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店番Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店名Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店名カナColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.伝票番号Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.社内伝番Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.口数Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.発注数量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送担当Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.県別Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原単価_税抜_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原価金額_税抜_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.発注区分Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納品指示Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一旦保留Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.受注日Column,
            this.ジャンルColumn1,
            this.店番Column1,
            this.店名Column1,
            this.店名カナColumn1,
            this.伝票番号Column1,
            this.社内伝番Column1,
            this.品名Column1,
            this.規格Column1,
            this.口数Column1,
            this.発注数量Column1,
            this.重量Column1,
            this.配送担当Column1,
            this.県別Column1,
            this.原単価_税抜_Column1,
            this.原価金額_税抜_Column1,
            this.発注区分Column1,
            this.納品指示Column1,
            this.一旦保留Column});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(834, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem1.Text = "ShippingConfirm";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.Filter = "";
            // 
            // shipperComboBox
            // 
            this.shipperComboBox.FormattingEnabled = true;
            this.shipperComboBox.Items.AddRange(new object[] {
            "All",
            "マツモト産業",
            "丸健",
            "MKL"});
            this.shipperComboBox.Location = new System.Drawing.Point(96, 16);
            this.shipperComboBox.Name = "shipperComboBox";
            this.shipperComboBox.Size = new System.Drawing.Size(121, 20);
            this.shipperComboBox.TabIndex = 2;
            this.shipperComboBox.SelectedIndexChanged += new System.EventHandler(this.shipperComboBox_SelectedIndexChanged);
            this.shipperComboBox.TextUpdate += new System.EventHandler(this.shipperComboBox_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "実際配送担当";
            // 
            // pager1
            // 
            this.pager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pager1.AutoSize = true;
            this.pager1.Location = new System.Drawing.Point(12, 414);
            this.pager1.Name = "pager1";
            this.pager1.NMax = 0;
            this.pager1.PageCount = 0;
            this.pager1.PageCurrent = 0;
            this.pager1.PageSize = 5000;
            this.pager1.Size = new System.Drawing.Size(834, 31);
            this.pager1.TabIndex = 4;
            this.pager1.EventPaging += new GODInventoryWinForm.Controls.EventPagingHandler(this.pager1_EventPaging);
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GODInventory.MyLinq.GODDbContext);
            // 
            // 受注日Column
            // 
            this.受注日Column.DataPropertyName = "受注日";
            this.受注日Column.HeaderText = "受注日";
            this.受注日Column.Name = "受注日Column";
            // 
            // ジャンルColumn1
            // 
            this.ジャンルColumn1.DataPropertyName = "ジャンル";
            this.ジャンルColumn1.HeaderText = "ジャンル";
            this.ジャンルColumn1.Name = "ジャンルColumn1";
            // 
            // 店番Column1
            // 
            this.店番Column1.DataPropertyName = "店番";
            this.店番Column1.HeaderText = "店番";
            this.店番Column1.Name = "店番Column1";
            // 
            // 店名Column1
            // 
            this.店名Column1.DataPropertyName = "店名";
            this.店名Column1.HeaderText = "店名";
            this.店名Column1.Name = "店名Column1";
            // 
            // 店名カナColumn1
            // 
            this.店名カナColumn1.DataPropertyName = "店舗名カナ";
            this.店名カナColumn1.HeaderText = "店名カナ";
            this.店名カナColumn1.Name = "店名カナColumn1";
            this.店名カナColumn1.ReadOnly = true;
            // 
            // 伝票番号Column1
            // 
            this.伝票番号Column1.DataPropertyName = "伝票番号";
            this.伝票番号Column1.HeaderText = "伝票番号";
            this.伝票番号Column1.Name = "伝票番号Column1";
            // 
            // 社内伝番Column1
            // 
            this.社内伝番Column1.DataPropertyName = "社内伝番";
            this.社内伝番Column1.HeaderText = "社内伝番";
            this.社内伝番Column1.Name = "社内伝番Column1";
            this.社内伝番Column1.ReadOnly = true;
            // 
            // 品名Column1
            // 
            this.品名Column1.DataPropertyName = "品名漢字";
            this.品名Column1.HeaderText = "品名";
            this.品名Column1.Name = "品名Column1";
            // 
            // 規格Column1
            // 
            this.規格Column1.DataPropertyName = "規格名漢字";
            this.規格Column1.HeaderText = "規格";
            this.規格Column1.Name = "規格Column1";
            // 
            // 口数Column1
            // 
            this.口数Column1.DataPropertyName = "口数";
            this.口数Column1.HeaderText = "口数";
            this.口数Column1.Name = "口数Column1";
            // 
            // 発注数量Column1
            // 
            this.発注数量Column1.DataPropertyName = "発注数量";
            this.発注数量Column1.HeaderText = "発注数量";
            this.発注数量Column1.Name = "発注数量Column1";
            // 
            // 重量Column1
            // 
            this.重量Column1.DataPropertyName = "重量";
            this.重量Column1.HeaderText = "重量";
            this.重量Column1.Name = "重量Column1";
            // 
            // 配送担当Column1
            // 
            this.配送担当Column1.DataPropertyName = "実際配送担当";
            this.配送担当Column1.HeaderText = "配送担当";
            this.配送担当Column1.Name = "配送担当Column1";
            // 
            // 県別Column1
            // 
            this.県別Column1.DataPropertyName = "県別";
            this.県別Column1.HeaderText = "県別";
            this.県別Column1.Name = "県別Column1";
            // 
            // 原単価_税抜_Column1
            // 
            this.原単価_税抜_Column1.DataPropertyName = "原単価_税抜_";
            this.原単価_税抜_Column1.HeaderText = "原単価(税抜)";
            this.原単価_税抜_Column1.Name = "原単価_税抜_Column1";
            this.原単価_税抜_Column1.ReadOnly = true;
            // 
            // 原価金額_税抜_Column1
            // 
            this.原価金額_税抜_Column1.DataPropertyName = "原価金額_税抜_";
            this.原価金額_税抜_Column1.HeaderText = "原価金額(税抜)";
            this.原価金額_税抜_Column1.Name = "原価金額_税抜_Column1";
            this.原価金額_税抜_Column1.ReadOnly = true;
            // 
            // 発注区分Column1
            // 
            this.発注区分Column1.DataPropertyName = "発注区分";
            this.発注区分Column1.HeaderText = "発注区分";
            this.発注区分Column1.Name = "発注区分Column1";
            this.発注区分Column1.ReadOnly = true;
            // 
            // 納品指示Column1
            // 
            this.納品指示Column1.DataPropertyName = "納品指示";
            this.納品指示Column1.HeaderText = "納品指示";
            this.納品指示Column1.Name = "納品指示Column1";
            // 
            // 一旦保留Column
            // 
            this.一旦保留Column.HeaderText = "一旦保留";
            this.一旦保留Column.Name = "一旦保留Column";
            // 
            // WaitToShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 442);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipperComboBox);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitToShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WaitToShipForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GODInventory.ViewModel.EntityDataSource entityDataSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox shipperComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Pager pager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受注日Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ジャンルColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店番Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店名Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店名カナColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 伝票番号Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社内伝番Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 口数Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 発注数量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送担当Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 県別Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原単価_税抜_Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原価金額_税抜_Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 発注区分Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納品指示Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一旦保留Column;
    }
}