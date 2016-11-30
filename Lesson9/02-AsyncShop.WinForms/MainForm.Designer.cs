namespace _02_AsyncShop.WinForms
{
    partial class MainForm
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
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(6, 25);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 0;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.cbManufacturer);
            this.groupBox1.Controls.Add(this.lblManufacturer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 70);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(652, 312);
            this.dgvProducts.TabIndex = 5;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(564, 39);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(82, 23);
            this.btnLoadData.TabIndex = 4;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(292, 41);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(266, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(289, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(9, 41);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(266, 21);
            this.cbManufacturer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

