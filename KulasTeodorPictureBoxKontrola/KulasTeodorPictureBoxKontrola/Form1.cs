using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulasTeodorPictureBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrikazSlike_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Picture Box Kontrola \nIme učenika: Teodor \nPrezime učenika: Kulaš \nDatum izrade: 22.1.2019");
        }
    }
}
