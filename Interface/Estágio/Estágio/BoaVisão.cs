using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estágio
{
    public partial class BoaVisão : Form
    {
        public BoaVisão()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 fmr = new Form1();
            fmr.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Matemática mat = new Matemática();
            mat.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Química qui = new Química();
            qui.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Física fis = new Física();
            fis.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }
    }
}
