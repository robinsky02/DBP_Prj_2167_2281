namespace prj_2167_2281
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.예약관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사이트관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고객관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예약관리ToolStripMenuItem,
            this.사이트관리ToolStripMenuItem,
            this.고객관리ToolStripMenuItem,
            this.직원관리ToolStripMenuItem,
            this.옵션관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 예약관리ToolStripMenuItem
            // 
            this.예약관리ToolStripMenuItem.Name = "예약관리ToolStripMenuItem";
            this.예약관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.예약관리ToolStripMenuItem.Text = "예약관리";
            this.예약관리ToolStripMenuItem.Click += new System.EventHandler(this.예약관리ToolStripMenuItem_Click);
            // 
            // 사이트관리ToolStripMenuItem
            // 
            this.사이트관리ToolStripMenuItem.Name = "사이트관리ToolStripMenuItem";
            this.사이트관리ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.사이트관리ToolStripMenuItem.Text = "사이트관리";
            this.사이트관리ToolStripMenuItem.Click += new System.EventHandler(this.사이트관리ToolStripMenuItem_Click);
            // 
            // 고객관리ToolStripMenuItem
            // 
            this.고객관리ToolStripMenuItem.Name = "고객관리ToolStripMenuItem";
            this.고객관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.고객관리ToolStripMenuItem.Text = "고객관리";
            this.고객관리ToolStripMenuItem.Click += new System.EventHandler(this.고객관리ToolStripMenuItem_Click);
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.직원관리ToolStripMenuItem.Text = "직원관리";
            this.직원관리ToolStripMenuItem.Click += new System.EventHandler(this.직원관리ToolStripMenuItem_Click);
            // 
            // 옵션관리ToolStripMenuItem
            // 
            this.옵션관리ToolStripMenuItem.Name = "옵션관리ToolStripMenuItem";
            this.옵션관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.옵션관리ToolStripMenuItem.Text = "옵션관리";
            this.옵션관리ToolStripMenuItem.Click += new System.EventHandler(this.옵션관리ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 578);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 예약관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사이트관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션관리ToolStripMenuItem;
    }
}