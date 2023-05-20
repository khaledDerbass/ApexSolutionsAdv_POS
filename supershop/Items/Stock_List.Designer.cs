namespace supershop
{
    partial class Stock_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_List));
            this.txtItemSearchBar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.picCloseEvent = new System.Windows.Forms.PictureBox();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChart = new System.Windows.Forms.Button();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.bntStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateBarcode = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnpurchasehistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEvent)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemSearchBar
            // 
            this.txtItemSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtItemSearchBar.Location = new System.Drawing.Point(17, 50);
            this.txtItemSearchBar.Name = "txtItemSearchBar";
            this.txtItemSearchBar.Size = new System.Drawing.Size(815, 21);
            this.txtItemSearchBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtItemSearchBar, "Search by Product Code / Barcode OR  Name ");
            this.txtItemSearchBar.TextChanged += new System.EventHandler(this.txtItemSearchBar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label6.Location = new System.Drawing.Point(15, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "Search Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picCloseEvent);
            this.panel1.Controls.Add(this.lblMinimized);
            this.panel1.Location = new System.Drawing.Point(5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 30);
            this.panel1.TabIndex = 37;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stock Item";
            // 
            // picCloseEvent
            // 
            this.picCloseEvent.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCloseEvent.Image = ((System.Drawing.Image)(resources.GetObject("picCloseEvent.Image")));
            this.picCloseEvent.Location = new System.Drawing.Point(1137, 5);
            this.picCloseEvent.Name = "picCloseEvent";
            this.picCloseEvent.Size = new System.Drawing.Size(21, 21);
            this.picCloseEvent.TabIndex = 41;
            this.picCloseEvent.TabStop = false;
            this.picCloseEvent.Click += new System.EventHandler(this.picCloseEvent_Click);
            // 
            // lblMinimized
            // 
            this.lblMinimized.AutoSize = true;
            this.lblMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMinimized.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinimized.Location = new System.Drawing.Point(1111, 2);
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Size = new System.Drawing.Size(19, 25);
            this.lblMinimized.TabIndex = 38;
            this.lblMinimized.Text = "-";
            this.toolTip1.SetToolTip(this.lblMinimized, "Minimize");
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 39000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnChart
            // 
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.Location = new System.Drawing.Point(981, 515);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(55, 56);
            this.btnChart.TabIndex = 10;
            this.btnChart.Text = "Chart";
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnChart, "Buying and Sale Rate Comparison");
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // combCategory
            // 
            this.combCategory.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Location = new System.Drawing.Point(838, 48);
            this.combCategory.Name = "combCategory";
            this.combCategory.Size = new System.Drawing.Size(328, 23);
            this.combCategory.TabIndex = 150;
            this.toolTip1.SetToolTip(this.combCategory, "Please Select Item category");
            this.combCategory.SelectedIndexChanged += new System.EventHandler(this.combCategory_SelectedIndexChanged);
            // 
            // bntStock
            // 
            this.bntStock.FlatAppearance.BorderSize = 0;
            this.bntStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bntStock.Image = ((System.Drawing.Image)(resources.GetObject("bntStock.Image")));
            this.bntStock.Location = new System.Drawing.Point(657, 515);
            this.bntStock.Name = "bntStock";
            this.bntStock.Size = new System.Drawing.Size(118, 56);
            this.bntStock.TabIndex = 153;
            this.bntStock.Text = "Stock Details";
            this.bntStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.bntStock, "Stock details: Item quantity alert");
            this.bntStock.UseVisualStyleBackColor = true;
            this.bntStock.Click += new System.EventHandler(this.bntStock_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(5, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 22);
            this.panel2.TabIndex = 38;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            // 
            // btnCreateBarcode
            // 
            this.btnCreateBarcode.FlatAppearance.BorderSize = 0;
            this.btnCreateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCreateBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBarcode.Image")));
            this.btnCreateBarcode.Location = new System.Drawing.Point(1047, 510);
            this.btnCreateBarcode.Name = "btnCreateBarcode";
            this.btnCreateBarcode.Size = new System.Drawing.Size(126, 61);
            this.btnCreateBarcode.TabIndex = 9;
            this.btnCreateBarcode.Text = "Create Barcode";
            this.btnCreateBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateBarcode.UseVisualStyleBackColor = true;
            this.btnCreateBarcode.Click += new System.EventHandler(this.btnCreateBarcode_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(869, 515);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 58);
            this.btnImport.TabIndex = 56;
            this.btnImport.Text = "Import Item";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanelUserList);
            this.panel3.Location = new System.Drawing.Point(12, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 422);
            this.panel3.TabIndex = 145;
            // 
            // flowLayoutPanelUserList
            // 
            this.flowLayoutPanelUserList.AutoScroll = true;
            this.flowLayoutPanelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUserList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            this.flowLayoutPanelUserList.Size = new System.Drawing.Size(1154, 422);
            this.flowLayoutPanelUserList.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label24.Location = new System.Drawing.Point(835, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 14);
            this.label24.TabIndex = 149;
            this.label24.Text = "Select Category";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(14, 538);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(13, 13);
            this.lblRows.TabIndex = 151;
            this.lblRows.Text = "0";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(781, 515);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(73, 56);
            this.btnAddNew.TabIndex = 152;
            this.btnAddNew.Text = "Add New ";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnpurchasehistory
            // 
            this.btnpurchasehistory.FlatAppearance.BorderSize = 0;
            this.btnpurchasehistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchasehistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnpurchasehistory.Image = ((System.Drawing.Image)(resources.GetObject("btnpurchasehistory.Image")));
            this.btnpurchasehistory.Location = new System.Drawing.Point(533, 516);
            this.btnpurchasehistory.Name = "btnpurchasehistory";
            this.btnpurchasehistory.Size = new System.Drawing.Size(118, 56);
            this.btnpurchasehistory.TabIndex = 154;
            this.btnpurchasehistory.Text = "Purchase History";
            this.btnpurchasehistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnpurchasehistory, "Purchase history: Item purchase records");
            this.btnpurchasehistory.UseVisualStyleBackColor = true;
            this.btnpurchasehistory.Click += new System.EventHandler(this.btnpurchasehistory_Click);
            // 
            // Stock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 593);
            this.Controls.Add(this.btnpurchasehistory);
            this.Controls.Add(this.bntStock);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.combCategory);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnCreateBarcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemSearchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock_List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.detail_info_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.detail_info_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEvent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemSearchBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateBarcode;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.PictureBox picCloseEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button bntStock;
        private System.Windows.Forms.Button btnpurchasehistory;
    }
}