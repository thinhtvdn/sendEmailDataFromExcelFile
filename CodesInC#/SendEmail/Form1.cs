using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gửiEmailDữLiệuTừFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendEmailExcel settingsForm = new SendEmailExcel();
            settingsForm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTKGuiThongTin settingsForm = new FrmTKGuiThongTin();
            settingsForm.Show();
        }

        private void thiếtLậpMáyChủSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSMTP settingsForm = new FrmSMTP();
            settingsForm.Show();
        }

        private void emGu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chuyểnĐổiGRAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void phiêuTrăcNghiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }



     
    }
}
