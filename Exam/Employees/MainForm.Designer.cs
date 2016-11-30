namespace Employees
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
            this.btnGenerateEmployee = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.groupBoxEmployees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateEmployee
            // 
            this.btnGenerateEmployee.Location = new System.Drawing.Point(115, 293);
            this.btnGenerateEmployee.Name = "btnGenerateEmployee";
            this.btnGenerateEmployee.Size = new System.Drawing.Size(111, 31);
            this.btnGenerateEmployee.TabIndex = 0;
            this.btnGenerateEmployee.Text = "Generate";
            this.btnGenerateEmployee.UseVisualStyleBackColor = true;
            this.btnGenerateEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(6, 19);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(220, 264);
            this.lbEmployees.TabIndex = 1;
            this.lbEmployees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbEmployees_MouseDoubleClick);
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Controls.Add(this.btnCreateEmployee);
            this.groupBoxEmployees.Controls.Add(this.lbEmployees);
            this.groupBoxEmployees.Controls.Add(this.btnGenerateEmployee);
            this.groupBoxEmployees.Location = new System.Drawing.Point(13, 13);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(232, 330);
            this.groupBoxEmployees.TabIndex = 2;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Employees:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLog);
            this.groupBox1.Location = new System.Drawing.Point(260, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 330);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log:";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(6, 19);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(404, 264);
            this.lbLog.TabIndex = 1;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(6, 293);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(103, 31);
            this.btnCreateEmployee.TabIndex = 2;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEmployees);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateEmployee;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnCreateEmployee;
    }
}

