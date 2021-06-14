using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2009
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmCalc fCalc;
        public Despre fDe;
        public BD Fbd;
        public Rotire frmRot;

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCalc = new frmCalc();
            fCalc.MdiParent = this;
            fCalc.Show();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDe = new Despre();
            fDe.MdiParent = this;
            fDe.Show();
        }

        private void bDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fbd = new BD();
            Fbd.MdiParent = this;
            Fbd.Show();
        }

        private void rotireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRot = new Rotire();
            frmRot.MdiParent = this;
            frmRot.Show();
        }
    }
}
