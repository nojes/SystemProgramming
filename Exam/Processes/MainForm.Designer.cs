namespace Processes
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
            this.btnRunCalc = new System.Windows.Forms.Button();
            this.btnRunNotepad = new System.Windows.Forms.Button();
            this.lbProcesses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRunCalc
            // 
            this.btnRunCalc.Location = new System.Drawing.Point(12, 253);
            this.btnRunCalc.Name = "btnRunCalc";
            this.btnRunCalc.Size = new System.Drawing.Size(88, 23);
            this.btnRunCalc.TabIndex = 0;
            this.btnRunCalc.Text = "Run Calc";
            this.btnRunCalc.UseVisualStyleBackColor = true;
            this.btnRunCalc.Click += new System.EventHandler(this.btnRunCalc_Click);
            // 
            // btnRunNotepad
            // 
            this.btnRunNotepad.Location = new System.Drawing.Point(115, 253);
            this.btnRunNotepad.Name = "btnRunNotepad";
            this.btnRunNotepad.Size = new System.Drawing.Size(95, 23);
            this.btnRunNotepad.TabIndex = 1;
            this.btnRunNotepad.Text = "Run notepad";
            this.btnRunNotepad.UseVisualStyleBackColor = true;
            this.btnRunNotepad.Click += new System.EventHandler(this.btnRunNotepad_Click);
            // 
            // lbProcesses
            // 
            this.lbProcesses.FormattingEnabled = true;
            this.lbProcesses.Location = new System.Drawing.Point(12, 13);
            this.lbProcesses.Name = "lbProcesses";
            this.lbProcesses.Size = new System.Drawing.Size(198, 225);
            this.lbProcesses.TabIndex = 2;
            this.lbProcesses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbProcesses_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 288);
            this.Controls.Add(this.lbProcesses);
            this.Controls.Add(this.btnRunNotepad);
            this.Controls.Add(this.btnRunCalc);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunCalc;
        private System.Windows.Forms.Button btnRunNotepad;
        private System.Windows.Forms.ListBox lbProcesses;
    }
}

