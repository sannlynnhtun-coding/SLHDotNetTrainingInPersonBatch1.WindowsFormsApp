using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            this.Close();
            //Application.Exit();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSale frm = new FrmSale();
            frm.ShowDialog();
        }
    }
}
