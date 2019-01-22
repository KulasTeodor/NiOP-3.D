using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KulasTeodorRichTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCitaj_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.LoadFile(@"C:Tempproba.rtf");
            }

        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.Clear();
            }

        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.SaveFile(@"C:Tempproba.rtf");
                MessageBox.Show("Tekst spremljen");
            }

        }

        private void teodorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naziv programa: Rich Text Box Kontrola \nIme učenika: Teodor \nPrezime učenika: Kulaš \nDatum izrade: 21.1.2019");

        }
    }
}
