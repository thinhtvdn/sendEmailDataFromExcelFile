namespace SendEmail
{
    partial class FrmTKGuiThongTin
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
            this.txttenTaiKhoanEmailGui = new System.Windows.Forms.TextBox();
            this.LblPassSender = new System.Windows.Forms.Label();
            this.txtPassSender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubjectEmail = new System.Windows.Forms.Label();
            this.txtSubjectEmail = new System.Windows.Forms.TextBox();
            this.rtxHeader = new System.Windows.Forms.TextBox();
            this.rtxFooter = new System.Windows.Forms.RichTextBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblEmailSender = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttenTaiKhoanEmailGui
            // 
            this.txttenTaiKhoanEmailGui.Location = new System.Drawing.Point(147, 12);
            this.txttenTaiKhoanEmailGui.Name = "txttenTaiKhoanEmailGui";
            this.txttenTaiKhoanEmailGui.Size = new System.Drawing.Size(217, 20);
            this.txttenTaiKhoanEmailGui.TabIndex = 0;
            // 
            // LblPassSender
            // 
            this.LblPassSender.AutoSize = true;
            this.LblPassSender.Location = new System.Drawing.Point(13, 41);
            this.LblPassSender.Name = "LblPassSender";
            this.LblPassSender.Size = new System.Drawing.Size(128, 13);
            this.LblPassSender.TabIndex = 4;
            this.LblPassSender.Text = "Mật khẩu đăng nhập mail";
            // 
            // txtPassSender
            // 
            this.txtPassSender.Location = new System.Drawing.Point(147, 38);
            this.txtPassSender.Name = "txtPassSender";
            this.txtPassSender.Size = new System.Drawing.Size(217, 20);
            this.txtPassSender.TabIndex = 7;
            this.txtPassSender.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dòng đầu email";
            // 
            // lblSubjectEmail
            // 
            this.lblSubjectEmail.AutoSize = true;
            this.lblSubjectEmail.Location = new System.Drawing.Point(13, 67);
            this.lblSubjectEmail.Name = "lblSubjectEmail";
            this.lblSubjectEmail.Size = new System.Drawing.Size(86, 13);
            this.lblSubjectEmail.TabIndex = 10;
            this.lblSubjectEmail.Text = "Tiêu đề của mail";
            // 
            // txtSubjectEmail
            // 
            this.txtSubjectEmail.Location = new System.Drawing.Point(147, 62);
            this.txtSubjectEmail.Name = "txtSubjectEmail";
            this.txtSubjectEmail.Size = new System.Drawing.Size(463, 20);
            this.txtSubjectEmail.TabIndex = 11;
            // 
            // rtxHeader
            // 
            this.rtxHeader.Location = new System.Drawing.Point(147, 86);
            this.rtxHeader.Name = "rtxHeader";
            this.rtxHeader.Size = new System.Drawing.Size(463, 20);
            this.rtxHeader.TabIndex = 20;
            // 
            // rtxFooter
            // 
            this.rtxFooter.Location = new System.Drawing.Point(147, 112);
            this.rtxFooter.Name = "rtxFooter";
            this.rtxFooter.Size = new System.Drawing.Size(463, 85);
            this.rtxFooter.TabIndex = 21;
            this.rtxFooter.Text = "";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(13, 115);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(83, 13);
            this.lblFooter.TabIndex = 22;
            this.lblFooter.Text = "Dòng cuối email";
            // 
            // lblEmailSender
            // 
            this.lblEmailSender.AutoSize = true;
            this.lblEmailSender.Location = new System.Drawing.Point(13, 15);
            this.lblEmailSender.Name = "lblEmailSender";
            this.lblEmailSender.Size = new System.Drawing.Size(107, 13);
            this.lblEmailSender.TabIndex = 23;
            this.lblEmailSender.Text = "Địa chỉ mail người gởi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Lưu tất cả thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(329, 207);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(182, 23);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "Xóa tất cả thông tin đã lưu";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // FrmTKGuiThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 241);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmailSender);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.rtxFooter);
            this.Controls.Add(this.rtxHeader);
            this.Controls.Add(this.txtSubjectEmail);
            this.Controls.Add(this.lblSubjectEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassSender);
            this.Controls.Add(this.LblPassSender);
            this.Controls.Add(this.txttenTaiKhoanEmailGui);
            this.KeyPreview = true;
            this.Name = "FrmTKGuiThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập thông tin để gửi email";
            this.Load += new System.EventHandler(this.FrmTKGuiThongTin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTKGuiThongTin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenTaiKhoanEmailGui;
        private System.Windows.Forms.Label LblPassSender;
        private System.Windows.Forms.TextBox txtPassSender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubjectEmail;
        private System.Windows.Forms.TextBox txtSubjectEmail;
        private System.Windows.Forms.TextBox rtxHeader;
        private System.Windows.Forms.RichTextBox rtxFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblEmailSender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
    }
}