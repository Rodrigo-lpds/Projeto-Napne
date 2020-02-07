using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add
{
    public partial class Resposta_Errada : Form
    {
        public string seda;
        public Resposta_Errada()
        {
            InitializeComponent();
        }
        public Resposta_Errada(string seda)
        {
            InitializeComponent();
            label5.Text = "a alternativa "+ seda;
        }
        private void Resposta_Errada_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resposta_Errada_Shown_1(object sender, EventArgs e)
        {
           // Voz.select(label1.Text + label2.Text + label3.Text + label4.Text + label5.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
