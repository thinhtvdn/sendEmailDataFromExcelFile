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
    public partial class FrmPathSaveImage : Form
    {
        public FrmPathSaveImage()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtPathImgs.Text = "";
            SendEmail.Properties.Settings.Default.pathImgs = "";
            SendEmail.Properties.Settings.Default.Save();
            MessageBox.Show(" Đã xoá thông tin");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SendEmail.Properties.Settings.Default.pathImgs = txtPathImgs.Text;
            SendEmail.Properties.Settings.Default.Save();
            MessageBox.Show(" Đã lưu thông tin");
        }

        private void FrmPathSaveImage_Load(object sender, EventArgs e)
        {
            txtPathImgs.Text = SendEmail.Properties.Settings.Default.pathImgs;
        }

        private void FrmPathSaveImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
