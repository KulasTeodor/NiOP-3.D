using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulasTeodorTimeKomponenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void labelVrijeme_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelVrijeme.Text = DateTime.Now.ToShortTimeString();

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Timer kontrola \nIme učenika: Teodor \nPrezime učenika: Kulaš \nDatum izrade: 21.1.2019");
        }
    }
}
