namespace Tools_Database_Stock
{
    partial class warehouseTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warehouseTable));
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolsDatabaseDataSet = new Tools_Database_Stock.ToolsDatabaseDataSet();
            this.toolStockTableTableAdapter = new Tools_Database_Stock.ToolsDatabaseDataSetTableAdapters.ToolStockTableTableAdapter();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.printStockNeededButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(629, 322);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(152, 62);
            this.backToMenuButton.TabIndex = 0;
            this.backToMenuButton.Text = "Back to menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(223, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(382, 45);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Tools Warehouse Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toolIDDataGridViewTextBoxColumn,
            this.toolNameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.stockNeededDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toolStockTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolIDDataGridViewTextBoxColumn
            // 
            this.toolIDDataGridViewTextBoxColumn.DataPropertyName = "ToolID";
            this.toolIDDataGridViewTextBoxColumn.HeaderText = "ToolID";
            this.toolIDDataGridViewTextBoxColumn.Name = "toolIDDataGridViewTextBoxColumn";
            this.toolIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.toolIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // toolNameDataGridViewTextBoxColumn
            // 
            this.toolNameDataGridViewTextBoxColumn.DataPropertyName = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.HeaderText = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.Name = "toolNameDataGridViewTextBoxColumn";
            this.toolNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.toolNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 50;
            // 
            // stockNeededDataGridViewTextBoxColumn
            // 
            this.stockNeededDataGridViewTextBoxColumn.DataPropertyName = "StockNeeded";
            this.stockNeededDataGridViewTextBoxColumn.HeaderText = "StockNeeded";
            this.stockNeededDataGridViewTextBoxColumn.Name = "stockNeededDataGridViewTextBoxColumn";
            this.stockNeededDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStockTableBindingSource
            // 
            this.toolStockTableBindingSource.DataMember = "ToolStockTable";
            this.toolStockTableBindingSource.DataSource = this.toolsDatabaseDataSet;
            // 
            // toolsDatabaseDataSet
            // 
            this.toolsDatabaseDataSet.DataSetName = "ToolsDatabaseDataSet";
            this.toolsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStockTableTableAdapter
            // 
            this.toolStockTableTableAdapter.ClearBeforeFill = true;
            // 
            // updateStockButton
            // 
            this.updateStockButton.Location = new System.Drawing.Point(642, 192);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(128, 40);
            this.updateStockButton.TabIndex = 4;
            this.updateStockButton.Text = "Update stock";
            this.updateStockButton.UseVisualStyleBackColor = true;
            this.updateStockButton.Click += new System.EventHandler(this.updateStockButton_Click);
            // 
            // printStockNeededButton
            // 
            this.printStockNeededButton.Location = new System.Drawing.Point(641, 253);
            this.printStockNeededButton.Name = "printStockNeededButton";
            this.printStockNeededButton.Size = new System.Drawing.Size(130, 45);
            this.printStockNeededButton.TabIndex = 5;
            this.printStockNeededButton.Text = "Check for what stock is needed";
            this.printStockNeededButton.UseVisualStyleBackColor = true;
            this.printStockNeededButton.Click += new System.EventHandler(this.printStockNeededButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 303);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 303);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(185, -32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(454, 113);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 73);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // warehouseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.printStockNeededButton);
            this.Controls.Add(this.updateStockButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "warehouseTable";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.warehouseTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolStockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToolsDatabaseDataSet toolsDatabaseDataSet;
        private System.Windows.Forms.BindingSource toolStockTableBindingSource;
        private ToolsDatabaseDataSetTableAdapters.ToolStockTableTableAdapter toolStockTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNeededDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateStockButton;
        private System.Windows.Forms.Button printStockNeededButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}