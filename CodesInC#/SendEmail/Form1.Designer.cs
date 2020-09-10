namespace SendEmail
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpMáyChủSMTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtLậpMáyChủSMTPToolStripMenuItem,
            this.toolStripMenuItem2,
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Gửi Email";
            // 
            // thiếtLậpMáyChủSMTPToolStripMenuItem
            // 
            this.thiếtLậpMáyChủSMTPToolStripMenuItem.Image = global::SendEmail.Properties.Resources.mnu_SMTP;
            this.thiếtLậpMáyChủSMTPToolStripMenuItem.Name = "thiếtLậpMáyChủSMTPToolStripMenuItem";
            this.thiếtLậpMáyChủSMTPToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.thiếtLậpMáyChủSMTPToolStripMenuItem.Text = "Thiết lập máy chủ SMTP";
            this.thiếtLậpMáyChủSMTPToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpMáyChủSMTPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::SendEmail.Properties.Resources.email_2_icon;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 22);
            this.toolStripMenuItem2.Text = "Thiết lập thông tin gửi email";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // gửiEmailDữLiệuTừFileExcelToolStripMenuItem
            // 
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem.Image = global::SendEmail.Properties.Resources.excel;
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem.Name = "gửiEmailDữLiệuTừFileExcelToolStripMenuItem";
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem.Text = "Dữ liệu từ file excel";
            this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem.Click += new System.EventHandler(this.gửiEmailDữLiệuTừFileExcelToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(783, 361);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gửi thông tin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gửiEmailDữLiệuTừFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpMáyChủSMTPToolStripMenuItem;
    }
}

