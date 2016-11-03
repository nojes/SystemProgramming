namespace ThreadsList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCreatedThreads = new System.Windows.Forms.Label();
            this.labelWaitingThreads = new System.Windows.Forms.Label();
            this.lbCreatedThreads = new System.Windows.Forms.ListBox();
            this.lbWaitingThreads = new System.Windows.Forms.ListBox();
            this.labelRunningThreads = new System.Windows.Forms.Label();
            this.lbRunningThreads = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.numSlotCount = new System.Windows.Forms.NumericUpDown();
            this.labelSlotCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCreatedThreads);
            this.groupBox1.Controls.Add(this.labelWaitingThreads);
            this.groupBox1.Controls.Add(this.lbCreatedThreads);
            this.groupBox1.Controls.Add(this.lbWaitingThreads);
            this.groupBox1.Controls.Add(this.labelRunningThreads);
            this.groupBox1.Controls.Add(this.lbRunningThreads);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threads";
            // 
            // labelCreatedThreads
            // 
            this.labelCreatedThreads.AutoSize = true;
            this.labelCreatedThreads.Location = new System.Drawing.Point(374, 20);
            this.labelCreatedThreads.Name = "labelCreatedThreads";
            this.labelCreatedThreads.Size = new System.Drawing.Size(47, 13);
            this.labelCreatedThreads.TabIndex = 7;
            this.labelCreatedThreads.Text = "Created:";
            // 
            // labelWaitingThreads
            // 
            this.labelWaitingThreads.AutoSize = true;
            this.labelWaitingThreads.Location = new System.Drawing.Point(211, 20);
            this.labelWaitingThreads.Name = "labelWaitingThreads";
            this.labelWaitingThreads.Size = new System.Drawing.Size(46, 13);
            this.labelWaitingThreads.TabIndex = 6;
            this.labelWaitingThreads.Text = "Waiting:";
            // 
            // lbCreatedThreads
            // 
            this.lbCreatedThreads.FormattingEnabled = true;
            this.lbCreatedThreads.Location = new System.Drawing.Point(316, 36);
            this.lbCreatedThreads.Name = "lbCreatedThreads";
            this.lbCreatedThreads.Size = new System.Drawing.Size(149, 173);
            this.lbCreatedThreads.TabIndex = 5;
            // 
            // lbWaitingThreads
            // 
            this.lbWaitingThreads.FormattingEnabled = true;
            this.lbWaitingThreads.Location = new System.Drawing.Point(161, 36);
            this.lbWaitingThreads.Name = "lbWaitingThreads";
            this.lbWaitingThreads.Size = new System.Drawing.Size(149, 173);
            this.lbWaitingThreads.TabIndex = 4;
            // 
            // labelRunningThreads
            // 
            this.labelRunningThreads.AutoSize = true;
            this.labelRunningThreads.Location = new System.Drawing.Point(54, 20);
            this.labelRunningThreads.Name = "labelRunningThreads";
            this.labelRunningThreads.Size = new System.Drawing.Size(50, 13);
            this.labelRunningThreads.TabIndex = 3;
            this.labelRunningThreads.Text = "Running:";
            // 
            // lbRunningThreads
            // 
            this.lbRunningThreads.FormattingEnabled = true;
            this.lbRunningThreads.Location = new System.Drawing.Point(6, 36);
            this.lbRunningThreads.Name = "lbRunningThreads";
            this.lbRunningThreads.Size = new System.Drawing.Size(149, 173);
            this.lbRunningThreads.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(390, 238);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 34);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // numSlotCount
            // 
            this.numSlotCount.Location = new System.Drawing.Point(85, 247);
            this.numSlotCount.Name = "numSlotCount";
            this.numSlotCount.Size = new System.Drawing.Size(79, 20);
            this.numSlotCount.TabIndex = 3;
            // 
            // labelSlotCount
            // 
            this.labelSlotCount.AutoSize = true;
            this.labelSlotCount.Location = new System.Drawing.Point(16, 249);
            this.labelSlotCount.Name = "labelSlotCount";
            this.labelSlotCount.Size = new System.Drawing.Size(63, 13);
            this.labelSlotCount.TabIndex = 4;
            this.labelSlotCount.Text = "Slots count:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.labelSlotCount);
            this.Controls.Add(this.numSlotCount);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCreatedThreads;
        private System.Windows.Forms.Label labelWaitingThreads;
        private System.Windows.Forms.ListBox lbCreatedThreads;
        private System.Windows.Forms.ListBox lbWaitingThreads;
        private System.Windows.Forms.Label labelRunningThreads;
        private System.Windows.Forms.ListBox lbRunningThreads;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numSlotCount;
        private System.Windows.Forms.Label labelSlotCount;
    }
}

