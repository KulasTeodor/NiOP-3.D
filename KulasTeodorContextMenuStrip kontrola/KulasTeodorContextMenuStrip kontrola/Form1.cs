using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulasTeodorContextMenuStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textBoxLijevo_TextChanged(object sender, EventArgs e)
        {
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDesno.Text = textBoxLijevo.Text;
        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLijevo.Text = textBoxDesno.Text;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Context Menu Strip kontrola \nIme učenika: Teodor \nPrezime učenika: Kulaš \nDatum izrade: 22.1.2019");
        }
    }
}
