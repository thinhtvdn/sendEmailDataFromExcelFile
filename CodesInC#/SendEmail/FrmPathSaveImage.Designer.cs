namespace SendEmail
{
    partial class FrmPathSaveImage
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmailSender = new System.Windows.Forms.Label();
            this.txtPathImgs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(10, 71);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(182, 23);
            this.btnDel.TabIndex = 34;
            this.btnDel.Text = "Xóa tất cả thông tin đã lưu";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu tất cả thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmailSender
            // 
            this.lblEmailSender.AutoSize = true;
            this.lblEmailSender.Location = new System.Drawing.Point(8, 15);
            this.lblEmailSender.Name = "lblEmailSender";
            this.lblEmailSender.Size = new System.Drawing.Size(66, 13);
            this.lblEmailSender.TabIndex = 36;
            this.lblEmailSender.Text = "Thư mục lưu";
            // 
            // txtPathImgs
            // 
            this.txtPathImgs.Location = new System.Drawing.Point(80, 12);
            this.txtPathImgs.Name = "txtPathImgs";
            this.txtPathImgs.Size = new System.Drawing.Size(217, 20);
            this.txtPathImgs.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Chú ý: Hai dấu gạch, ví dụ D:\\\\tmp\\\\";
            // 
            // FrmPathSaveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailSender);
            this.Controls.Add(this.txtPathImgs);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.KeyPreview = true;
            this.Name = "FrmPathSaveImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập vị trí lưu tập tin hình ảnh";
            this.Load += new System.EventHandler(this.FrmPathSaveImage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPathSaveImage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmailSender;
        private System.Windows.Forms.TextBox txtPathImgs;
        private System.Windows.Forms.Label label1;
    }
}