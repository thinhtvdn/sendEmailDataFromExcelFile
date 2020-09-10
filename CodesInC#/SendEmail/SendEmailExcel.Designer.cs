namespace SendEmail
{
    partial class SendEmailExcel
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.ExcelGridView = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnImpExcel = new System.Windows.Forms.Button();
            this.lblEmailSender = new System.Windows.Forms.Label();
            this.lblSubjectEmail = new System.Windows.Forms.Label();
            this.LblPassSender = new System.Windows.Forms.Label();
            this.txtEmailSender = new System.Windows.Forms.TextBox();
            this.txtPassSender = new System.Windows.Forms.TextBox();
            this.txtSubjectEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.rtxFooter = new System.Windows.Forms.RichTextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.rtxHeader = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.palCotHienThi = new DevExpress.XtraEditors.PanelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palCotHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.ExcelGridView;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = null;
            // 
            // ExcelGridView
            // 
            this.ExcelGridView.AllowDrop = true;
            gridLevelNode1.LevelTemplate = this.layoutView1;
            gridLevelNode1.RelationName = "Level1";
            this.ExcelGridView.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.ExcelGridView.Location = new System.Drawing.Point(0, 209);
            this.ExcelGridView.MainView = this.gridView1;
            this.ExcelGridView.Name = "ExcelGridView";
            this.ExcelGridView.Size = new System.Drawing.Size(1228, 401);
            this.ExcelGridView.TabIndex = 0;
            this.ExcelGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1});
            this.ExcelGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExcelGridView_DragDrop);
            this.ExcelGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExcelGridView_DragEnter);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.ExcelGridView;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // btnImpExcel
            // 
            this.btnImpExcel.Location = new System.Drawing.Point(621, 9);
            this.btnImpExcel.Name = "btnImpExcel";
            this.btnImpExcel.Size = new System.Drawing.Size(117, 23);
            this.btnImpExcel.TabIndex = 15;
            this.btnImpExcel.Text = "Chọn tập tin EXCEL";
            this.btnImpExcel.UseVisualStyleBackColor = true;
            this.btnImpExcel.Click += new System.EventHandler(this.btnImpExcel_Click);
            // 
            // lblEmailSender
            // 
            this.lblEmailSender.AutoSize = true;
            this.lblEmailSender.Location = new System.Drawing.Point(7, 9);
            this.lblEmailSender.Name = "lblEmailSender";
            this.lblEmailSender.Size = new System.Drawing.Size(107, 13);
            this.lblEmailSender.TabIndex = 1;
            this.lblEmailSender.Text = "Địa chỉ mail người gởi";
            // 
            // lblSubjectEmail
            // 
            this.lblSubjectEmail.AutoSize = true;
            this.lblSubjectEmail.Location = new System.Drawing.Point(7, 38);
            this.lblSubjectEmail.Name = "lblSubjectEmail";
            this.lblSubjectEmail.Size = new System.Drawing.Size(86, 13);
            this.lblSubjectEmail.TabIndex = 2;
            this.lblSubjectEmail.Text = "Tiêu đề của mail";
            // 
            // LblPassSender
            // 
            this.LblPassSender.AutoSize = true;
            this.LblPassSender.Location = new System.Drawing.Point(320, 15);
            this.LblPassSender.Name = "LblPassSender";
            this.LblPassSender.Size = new System.Drawing.Size(128, 13);
            this.LblPassSender.TabIndex = 3;
            this.LblPassSender.Text = "Mật khẩu đăng nhập mail";
            // 
            // txtEmailSender
            // 
            this.txtEmailSender.Location = new System.Drawing.Point(152, 9);
            this.txtEmailSender.Name = "txtEmailSender";
            this.txtEmailSender.Size = new System.Drawing.Size(150, 20);
            this.txtEmailSender.TabIndex = 5;
            // 
            // txtPassSender
            // 
            this.txtPassSender.Location = new System.Drawing.Point(465, 12);
            this.txtPassSender.Name = "txtPassSender";
            this.txtPassSender.Size = new System.Drawing.Size(150, 20);
            this.txtPassSender.TabIndex = 6;
            this.txtPassSender.UseSystemPasswordChar = true;
            // 
            // txtSubjectEmail
            // 
            this.txtSubjectEmail.Location = new System.Drawing.Point(152, 38);
            this.txtSubjectEmail.Name = "txtSubjectEmail";
            this.txtSubjectEmail.Size = new System.Drawing.Size(463, 20);
            this.txtSubjectEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dòng đầu email";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(9, 98);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(83, 13);
            this.lblFooter.TabIndex = 13;
            this.lblFooter.Text = "Dòng cuối email";
            // 
            // rtxFooter
            // 
            this.rtxFooter.Location = new System.Drawing.Point(151, 90);
            this.rtxFooter.Name = "rtxFooter";
            this.rtxFooter.Size = new System.Drawing.Size(463, 85);
            this.rtxFooter.TabIndex = 14;
            this.rtxFooter.Text = "";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(623, 180);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(67, 23);
            this.btnSendEmail.TabIndex = 17;
            this.btnSendEmail.Text = "Gửi email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(744, 11);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(198, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // rtxHeader
            // 
            this.rtxHeader.Location = new System.Drawing.Point(151, 64);
            this.rtxHeader.Name = "rtxHeader";
            this.rtxHeader.Size = new System.Drawing.Size(463, 20);
            this.rtxHeader.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(621, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 121);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "DoubleClick để chọn sheet đọc dữ liệu";
            // 
            // palCotHienThi
            // 
            this.palCotHienThi.Location = new System.Drawing.Point(1021, 11);
            this.palCotHienThi.Name = "palCotHienThi";
            this.palCotHienThi.Size = new System.Drawing.Size(212, 193);
            this.palCotHienThi.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendEmailExcel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExcelGridView);
            this.Controls.Add(this.palCotHienThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rtxHeader);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.rtxFooter);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectEmail);
            this.Controls.Add(this.txtPassSender);
            this.Controls.Add(this.txtEmailSender);
            this.Controls.Add(this.LblPassSender);
            this.Controls.Add(this.lblSubjectEmail);
            this.Controls.Add(this.lblEmailSender);
            this.Controls.Add(this.btnImpExcel);
            this.KeyPreview = true;
            this.Name = "SendEmailExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi email - Dữ liệu từ file excel";
            this.Load += new System.EventHandler(this.SendEmailExcel_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SendEmailExcel_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendEmailExcel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palCotHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImpExcel;
        private System.Windows.Forms.Label lblEmailSender;
        private System.Windows.Forms.Label lblSubjectEmail;
        private System.Windows.Forms.Label LblPassSender;
        private System.Windows.Forms.TextBox txtEmailSender;
        private System.Windows.Forms.TextBox txtPassSender;
        private System.Windows.Forms.TextBox txtSubjectEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.RichTextBox rtxFooter;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox rtxHeader;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl palCotHienThi;
        private DevExpress.XtraGrid.GridControl ExcelGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}