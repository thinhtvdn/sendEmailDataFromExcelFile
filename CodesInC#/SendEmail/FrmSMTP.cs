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
    public partial class FrmSMTP : Form
    {
        public FrmSMTP()
        {
            InitializeComponent();
        }

        private void FrmSMTP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmSMTP_Load(object sender, EventArgs e)
        {
            InforSMTPServer obj = new InforSMTPServer();
            obj = clsEmail.getInforSMTP();  
            txtstrHost.Text = obj.strHost;
            txtport.Text = obj.port.ToString();
            if (obj.EnableSsl) chkSSL.Checked = true; 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            InforSMTPServer obj = new InforSMTPServer();
            obj.strHost = "";
            obj.EnableSsl = false;
            obj.port = 0;

            txtstrHost.Text = obj.strHost;
            txtport.Text  = obj.port.ToString() ;
            chkSSL.Checked = false; 
            if (clsEmail.SaveInforSMTP(obj)) MessageBox.Show(" Đã xoá thông tin");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InforSMTPServer obj = new InforSMTPServer();
            obj.strHost =txtstrHost.Text ;
            if (chkSSL.Checked) obj.EnableSsl = true; else obj.EnableSsl = false;
            obj.port =Convert.ToInt32(txtport.Text);
            if (clsEmail.SaveInforSMTP(obj)) MessageBox.Show(" Đã lưu thông tin"); 
        }
    }
}
