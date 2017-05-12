namespace PHPSolution
{
    partial class reportform
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
            this.multiline = new System.Windows.Forms.TextBox();
            this.weeklyreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiline
            // 
            this.multiline.Location = new System.Drawing.Point(12, 41);
            this.multiline.Multiline = true;
            this.multiline.Name = "multiline";
            this.multiline.ReadOnly = true;
            this.multiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.multiline.Size = new System.Drawing.Size(349, 367);
            this.multiline.TabIndex = 34;
            // 
            // weeklyreport
            // 
            this.weeklyreport.Location = new System.Drawing.Point(12, 12);
            this.weeklyreport.Name = "weeklyreport";
            this.weeklyreport.Size = new System.Drawing.Size(349, 23);
            this.weeklyreport.TabIndex = 35;
            this.weeklyreport.Text = "Weekly Report";
            this.weeklyreport.UseVisualStyleBackColor = true;
            this.weeklyreport.Click += new System.EventHandler(this.weeklyreport_Click);
            // 
            // reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 420);
            this.Controls.Add(this.weeklyreport);
            this.Controls.Add(this.multiline);
            this.Name = "reportform";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox multiline;
        private System.Windows.Forms.Button weeklyreport;
    }
}