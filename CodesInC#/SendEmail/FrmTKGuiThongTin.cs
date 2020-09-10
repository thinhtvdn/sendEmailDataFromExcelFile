using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class FrmTKGuiThongTin : Form
    {
        public FrmTKGuiThongTin()
        {
            InitializeComponent();
        }

        private void FrmTKGuiThongTin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.taikhoangui ="";
            Properties.Settings.Default.matkhaugui ="";
            Properties.Settings.Default.tieude = "";
            Properties.Settings.Default.dongdauemail = "";
            Properties.Settings.Default.dongcuoiemail = "";
            SendEmail.Properties.Settings.Default.Save();
            txttenTaiKhoanEmailGui.Text = "";
            txtPassSender.Text = "";
            txtSubjectEmail.Text = "";
            rtxHeader.Text = "";
            rtxFooter.Text = "";
            MessageBox.Show(" Đã xoá thông tin");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.taikhoangui = txttenTaiKhoanEmailGui.Text;
            Properties.Settings.Default.matkhaugui = txtPassSender.Text;
            Properties.Settings.Default.tieude = txtSubjectEmail.Text;
            Properties.Settings.Default.dongdauemail = rtxHeader.Text;
            Properties.Settings.Default.dongcuoiemail = rtxFooter.Text;
            SendEmail.Properties.Settings.Default.Save();
            MessageBox.Show(" Đã lưu thông tin");
        }

        private void FrmTKGuiThongTin_Load(object sender, EventArgs e)
        {
            txttenTaiKhoanEmailGui.Text = Properties.Settings.Default.taikhoangui;
            txtPassSender.Text = Properties.Settings.Default.matkhaugui;
            txtSubjectEmail.Text = Properties.Settings.Default.tieude;
            rtxHeader.Text = Properties.Settings.Default.dongdauemail;
            rtxFooter.Text = Properties.Settings.Default.dongcuoiemail;
        }
    }
}
