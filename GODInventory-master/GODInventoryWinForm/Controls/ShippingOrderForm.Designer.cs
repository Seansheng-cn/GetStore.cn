namespace GODInventoryWinForm.Controls
{
    partial class ShippingOrderForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.出荷日Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.納品日Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受注日Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店舗コードColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店名Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.伝票番号Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名漢字Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格名漢字Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.口数Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.発注数量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実際配送担当Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.県別Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原単価_税抜_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原価金額_税抜_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.発注形態名称漢字Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printForEDIButton = new System.Windows.Forms.Button();
            this.uploadForEDIButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.generateASNButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pager1 = new GODInventoryWinForm.Controls.Pager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.データIDColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理連番Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.レコード件数Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTabPage3 = new System.Windows.Forms.TabPage();
            this.pager3 = new GODInventoryWinForm.Controls.Pager();
            this.finishOrderButton1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.納品日Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受注日Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出荷日Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.店舗名漢字Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.伝票番号Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名漢字Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格名漢字Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実際出荷数量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実際配送担当Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受領Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受領数量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受領金額Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受領差異数量Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受領差異金額Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.entityDataSource1 = new GODInventory.ViewModel.EntityDataSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deliveryTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.出荷日Column1,
            this.納品日Column1,
            this.受注日Column1,
            this.店舗コードColumn1,
            this.店名Column1,
            this.伝票番号Column1,
            this.品名漢字Column1,
            this.規格名漢字Column1,
            this.口数Column1,
            this.発注数量Column1,
            this.重量Column2,
            this.実際配送担当Column1,
            this.県別Column1,
            this.原単価_税抜_Column1,
            this.原価金額_税抜_Column1,
            this.発注形態名称漢字Column1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(897, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // 出荷日Column1
            // 
            this.出荷日Column1.DataPropertyName = "出荷日";
            this.出荷日Column1.HeaderText = "出荷日";
            this.出荷日Column1.Name = "出荷日Column1";
            this.出荷日Column1.ReadOnly = true;
            // 
            // 納品日Column1
            // 
            this.納品日Column1.DataPropertyName = "納品日";
            this.納品日Column1.HeaderText = "納品日";
            this.納品日Column1.Name = "納品日Column1";
            this.納品日Column1.ReadOnly = true;
            // 
            // 受注日Column1
            // 
            this.受注日Column1.DataPropertyName = "受注日";
            this.受注日Column1.HeaderText = "受注日";
            this.受注日Column1.Name = "受注日Column1";
            this.受注日Column1.ReadOnly = true;
            // 
            // 店舗コードColumn1
            // 
            this.店舗コードColumn1.DataPropertyName = "店舗コード";
            this.店舗コードColumn1.HeaderText = "店舗コード";
            this.店舗コードColumn1.Name = "店舗コードColumn1";
            this.店舗コードColumn1.ReadOnly = true;
            // 
            // 店名Column1
            // 
            this.店名Column1.DataPropertyName = "店名";
            this.店名Column1.HeaderText = "店名";
            this.店名Column1.Name = "店名Column1";
            this.店名Column1.ReadOnly = true;
            // 
            // 伝票番号Column1
            // 
            this.伝票番号Column1.DataPropertyName = "伝票番号";
            this.伝票番号Column1.HeaderText = "伝票番号";
            this.伝票番号Column1.Name = "伝票番号Column1";
            this.伝票番号Column1.ReadOnly = true;
            // 
            // 品名漢字Column1
            // 
            this.品名漢字Column1.DataPropertyName = "品名漢字";
            this.品名漢字Column1.HeaderText = "品名";
            this.品名漢字Column1.Name = "品名漢字Column1";
            this.品名漢字Column1.ReadOnly = true;
            // 
            // 規格名漢字Column1
            // 
            this.規格名漢字Column1.DataPropertyName = "規格名漢字";
            this.規格名漢字Column1.HeaderText = "規格名";
            this.規格名漢字Column1.Name = "規格名漢字Column1";
            this.規格名漢字Column1.ReadOnly = true;
            // 
            // 口数Column1
            // 
            this.口数Column1.DataPropertyName = "口数";
            this.口数Column1.HeaderText = "口数";
            this.口数Column1.Name = "口数Column1";
            this.口数Column1.ReadOnly = true;
            // 
            // 発注数量Column1
            // 
            this.発注数量Column1.DataPropertyName = "発注数量";
            this.発注数量Column1.HeaderText = "発注数量";
            this.発注数量Column1.Name = "発注数量Column1";
            this.発注数量Column1.ReadOnly = true;
            // 
            // 重量Column2
            // 
            this.重量Column2.DataPropertyName = "重量";
            this.重量Column2.HeaderText = "重量";
            this.重量Column2.Name = "重量Column2";
            this.重量Column2.ReadOnly = true;
            // 
            // 実際配送担当Column1
            // 
            this.実際配送担当Column1.DataPropertyName = "実際配送担当";
            this.実際配送担当Column1.HeaderText = "実際配送担当";
            this.実際配送担当Column1.Name = "実際配送担当Column1";
            this.実際配送担当Column1.ReadOnly = true;
            // 
            // 県別Column1
            // 
            this.県別Column1.DataPropertyName = "県別";
            this.県別Column1.HeaderText = "県別";
            this.県別Column1.Name = "県別Column1";
            this.県別Column1.ReadOnly = true;
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
            // 発注形態名称漢字Column1
            // 
            this.発注形態名称漢字Column1.DataPropertyName = "発注形態名称漢字";
            this.発注形態名称漢字Column1.HeaderText = "発注形態名称漢字";
            this.発注形態名称漢字Column1.Name = "発注形態名称漢字Column1";
            this.発注形態名称漢字Column1.ReadOnly = true;
            // 
            // printForEDIButton
            // 
            this.printForEDIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printForEDIButton.Location = new System.Drawing.Point(660, 18);
            this.printForEDIButton.Name = "printForEDIButton";
            this.printForEDIButton.Size = new System.Drawing.Size(116, 23);
            this.printForEDIButton.TabIndex = 1;
            this.printForEDIButton.Text = "Print for EDI";
            this.printForEDIButton.UseVisualStyleBackColor = true;
            this.printForEDIButton.Click += new System.EventHandler(this.printForEDIButton_Click);
            // 
            // uploadForEDIButton
            // 
            this.uploadForEDIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadForEDIButton.Location = new System.Drawing.Point(782, 18);
            this.uploadForEDIButton.Name = "uploadForEDIButton";
            this.uploadForEDIButton.Size = new System.Drawing.Size(116, 23);
            this.uploadForEDIButton.TabIndex = 2;
            this.uploadForEDIButton.Text = "Upload for EDI";
            this.uploadForEDIButton.UseVisualStyleBackColor = true;
            this.uploadForEDIButton.Click += new System.EventHandler(this.uploadForEDIButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // generateASNButton
            // 
            this.generateASNButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateASNButton.Location = new System.Drawing.Point(786, 15);
            this.generateASNButton.Name = "generateASNButton";
            this.generateASNButton.Size = new System.Drawing.Size(116, 23);
            this.generateASNButton.TabIndex = 3;
            this.generateASNButton.Text = "GenerateASN";
            this.generateASNButton.UseVisualStyleBackColor = true;
            this.generateASNButton.Click += new System.EventHandler(this.generateASNButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.deliveryTabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 369);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pager1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.generateASNButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Shipment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pager1
            // 
            this.pager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pager1.AutoSize = true;
            this.pager1.Location = new System.Drawing.Point(6, 309);
            this.pager1.Name = "pager1";
            this.pager1.NMax = 0;
            this.pager1.PageCount = 0;
            this.pager1.PageCurrent = 0;
            this.pager1.PageSize = 5000;
            this.pager1.Size = new System.Drawing.Size(897, 31);
            this.pager1.TabIndex = 4;
            this.pager1.EventPaging += new GODInventoryWinForm.Controls.EventPagingHandler(this.pager1_EventPaging);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.uploadForEDIButton);
            this.tabPage2.Controls.Add(this.printForEDIButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ASN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.データIDColumn1,
            this.管理連番Column1,
            this.レコード件数Column1,
            this.createdAtColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(8, 61);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(893, 274);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // データIDColumn1
            // 
            this.データIDColumn1.DataPropertyName = "データID";
            this.データIDColumn1.HeaderText = "データID";
            this.データIDColumn1.Name = "データIDColumn1";
            this.データIDColumn1.ReadOnly = true;
            // 
            // 管理連番Column1
            // 
            this.管理連番Column1.DataPropertyName = "管理連番";
            this.管理連番Column1.HeaderText = "管理連番";
            this.管理連番Column1.Name = "管理連番Column1";
            this.管理連番Column1.ReadOnly = true;
            // 
            // レコード件数Column1
            // 
            this.レコード件数Column1.DataPropertyName = "レコード件数";
            this.レコード件数Column1.HeaderText = "レコード件数";
            this.レコード件数Column1.Name = "レコード件数Column1";
            this.レコード件数Column1.ReadOnly = true;
            // 
            // createdAtColumn1
            // 
            this.createdAtColumn1.DataPropertyName = "created_at";
            this.createdAtColumn1.HeaderText = "created_at";
            this.createdAtColumn1.Name = "createdAtColumn1";
            this.createdAtColumn1.ReadOnly = true;
            // 
            // deliveryTabPage3
            // 
            this.deliveryTabPage3.Controls.Add(this.pager3);
            this.deliveryTabPage3.Controls.Add(this.finishOrderButton1);
            this.deliveryTabPage3.Controls.Add(this.dataGridView3);
            this.deliveryTabPage3.Location = new System.Drawing.Point(4, 22);
            this.deliveryTabPage3.Name = "deliveryTabPage3";
            this.deliveryTabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.deliveryTabPage3.Size = new System.Drawing.Size(909, 343);
            this.deliveryTabPage3.TabIndex = 2;
            this.deliveryTabPage3.Text = "Receiving confirm";
            this.deliveryTabPage3.UseVisualStyleBackColor = true;
            // 
            // pager3
            // 
            this.pager3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pager3.AutoSize = true;
            this.pager3.Location = new System.Drawing.Point(0, 312);
            this.pager3.Name = "pager3";
            this.pager3.NMax = 0;
            this.pager3.PageCount = 0;
            this.pager3.PageCurrent = 0;
            this.pager3.PageSize = 5000;
            this.pager3.Size = new System.Drawing.Size(909, 31);
            this.pager3.TabIndex = 2;
            this.pager3.EventPaging += new GODInventoryWinForm.Controls.EventPagingHandler(this.pager3_EventPaging);
            // 
            // finishOrderButton1
            // 
            this.finishOrderButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finishOrderButton1.Location = new System.Drawing.Point(785, 15);
            this.finishOrderButton1.Name = "finishOrderButton1";
            this.finishOrderButton1.Size = new System.Drawing.Size(116, 23);
            this.finishOrderButton1.TabIndex = 1;
            this.finishOrderButton1.Text = "FinishOrder";
            this.finishOrderButton1.UseVisualStyleBackColor = true;
            this.finishOrderButton1.Click += new System.EventHandler(this.finishOrderButton1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.納品日Column21,
            this.受注日Column21,
            this.出荷日Column21,
            this.店舗名漢字Column1,
            this.伝票番号Column21,
            this.品名漢字Column21,
            this.規格名漢字Column21,
            this.実際出荷数量Column1,
            this.実際配送担当Column21,
            this.受領Column1,
            this.受領数量Column1,
            this.受領金額Column1,
            this.受領差異数量Column1,
            this.受領差異金額Column1});
            this.dataGridView3.Location = new System.Drawing.Point(6, 56);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(895, 254);
            this.dataGridView3.TabIndex = 0;
            // 
            // 納品日Column21
            // 
            this.納品日Column21.DataPropertyName = "納品日";
            this.納品日Column21.HeaderText = "納品日";
            this.納品日Column21.Name = "納品日Column21";
            // 
            // 受注日Column21
            // 
            this.受注日Column21.DataPropertyName = "受注日";
            this.受注日Column21.HeaderText = "受注日";
            this.受注日Column21.Name = "受注日Column21";
            // 
            // 出荷日Column21
            // 
            this.出荷日Column21.DataPropertyName = "出荷日";
            this.出荷日Column21.HeaderText = "出荷日";
            this.出荷日Column21.Name = "出荷日Column21";
            // 
            // 店舗名漢字Column1
            // 
            this.店舗名漢字Column1.DataPropertyName = "店舗名漢字";
            this.店舗名漢字Column1.HeaderText = "店舗名漢字";
            this.店舗名漢字Column1.Name = "店舗名漢字Column1";
            this.店舗名漢字Column1.ReadOnly = true;
            // 
            // 伝票番号Column21
            // 
            this.伝票番号Column21.DataPropertyName = "伝票番号";
            this.伝票番号Column21.HeaderText = "伝票番号";
            this.伝票番号Column21.Name = "伝票番号Column21";
            this.伝票番号Column21.ReadOnly = true;
            // 
            // 品名漢字Column21
            // 
            this.品名漢字Column21.DataPropertyName = "品名漢字";
            this.品名漢字Column21.HeaderText = "品名漢字";
            this.品名漢字Column21.Name = "品名漢字Column21";
            this.品名漢字Column21.ReadOnly = true;
            // 
            // 規格名漢字Column21
            // 
            this.規格名漢字Column21.DataPropertyName = "規格名漢字";
            this.規格名漢字Column21.HeaderText = "規格名漢字";
            this.規格名漢字Column21.Name = "規格名漢字Column21";
            this.規格名漢字Column21.ReadOnly = true;
            // 
            // 実際出荷数量Column1
            // 
            this.実際出荷数量Column1.DataPropertyName = "実際出荷数量";
            this.実際出荷数量Column1.HeaderText = "実際出荷数量";
            this.実際出荷数量Column1.Name = "実際出荷数量Column1";
            this.実際出荷数量Column1.ReadOnly = true;
            // 
            // 実際配送担当Column21
            // 
            this.実際配送担当Column21.DataPropertyName = "実際配送担当";
            this.実際配送担当Column21.HeaderText = "実際配送担当";
            this.実際配送担当Column21.Name = "実際配送担当Column21";
            this.実際配送担当Column21.ReadOnly = true;
            // 
            // 受領Column1
            // 
            this.受領Column1.DataPropertyName = "受領";
            this.受領Column1.HeaderText = "受領";
            this.受領Column1.Name = "受領Column1";
            this.受領Column1.ReadOnly = true;
            // 
            // 受領数量Column1
            // 
            this.受領数量Column1.DataPropertyName = "受領数量";
            this.受領数量Column1.HeaderText = "受領数量";
            this.受領数量Column1.Name = "受領数量Column1";
            this.受領数量Column1.ReadOnly = true;
            // 
            // 受領金額Column1
            // 
            this.受領金額Column1.DataPropertyName = "受領金額";
            this.受領金額Column1.HeaderText = "受領金額";
            this.受領金額Column1.Name = "受領金額Column1";
            this.受領金額Column1.ReadOnly = true;
            // 
            // 受領差異数量Column1
            // 
            this.受領差異数量Column1.DataPropertyName = "受領差異数量";
            this.受領差異数量Column1.HeaderText = "受領差異数量";
            this.受領差異数量Column1.Name = "受領差異数量Column1";
            this.受領差異数量Column1.ReadOnly = true;
            // 
            // 受領差異金額Column1
            // 
            this.受領差異金額Column1.DataPropertyName = "受領差異金額";
            this.受領差異金額Column1.HeaderText = "受領差異金額";
            this.受領差異金額Column1.Name = "受領差異金額Column1";
            this.受領差異金額Column1.ReadOnly = true;
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GODInventory.MyLinq.GODDbContext);
            // 
            // ShippingOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(917, 369);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShippingOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShippingOrdersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShippingOrderForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deliveryTabPage3.ResumeLayout(false);
            this.deliveryTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GODInventory.ViewModel.EntityDataSource entityDataSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printForEDIButton;
        private System.Windows.Forms.Button uploadForEDIButton;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button generateASNButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出荷日Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納品日Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受注日Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店舗コードColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店名Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 伝票番号Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名漢字Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格名漢字Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 口数Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 発注数量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実際配送担当Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 県別Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原単価_税抜_Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原価金額_税抜_Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 発注形態名称漢字Column1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn データIDColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理連番Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn レコード件数Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtColumn1;
        private Pager pager1;
        private System.Windows.Forms.TabPage deliveryTabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button finishOrderButton1;
        private Pager pager3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 納品日Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受注日Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出荷日Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 店舗名漢字Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 伝票番号Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名漢字Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格名漢字Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実際出荷数量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実際配送担当Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受領Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受領数量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受領金額Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受領差異数量Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受領差異金額Column1;
        private System.Windows.Forms.BindingSource bindingSource3;
    }
}