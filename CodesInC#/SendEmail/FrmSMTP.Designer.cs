namespace SendEmail
{
    partial class FrmSMTP
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
            this.lblEmailSender = new System.Windows.Forms.Label();
            this.txtstrHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmailSender
            // 
            this.lblEmailSender.AutoSize = true;
            this.lblEmailSender.Location = new System.Drawing.Point(10, 15);
            this.lblEmailSender.Name = "lblEmailSender";
            this.lblEmailSender.Size = new System.Drawing.Size(83, 13);
            this.lblEmailSender.TabIndex = 25;
            this.lblEmailSender.Text = "Địa chỉ máy chủ";
            // 
            // txtstrHost
            // 
            this.txtstrHost.Location = new System.Drawing.Point(116, 12);
            this.txtstrHost.Name = "txtstrHost";
            this.txtstrHost.Size = new System.Drawing.Size(217, 20);
            this.txtstrHost.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sử dụng SSL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số cổng";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(116, 64);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(34, 20);
            this.txtport.TabIndex = 28;
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(116, 42);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(15, 14);
            this.chkSSL.TabIndex = 30;
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 99);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(182, 23);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Xóa tất cả thông tin đã lưu";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Lưu tất cả thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(597, 132);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailSender);
            this.Controls.Add(this.txtstrHost);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FrmSMTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập máy chủ SMTP";
            this.Load += new System.EventHandler(this.FrmSMTP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSMTP_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailSender;
        private System.Windows.Forms.TextBox txtstrHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
    }
}