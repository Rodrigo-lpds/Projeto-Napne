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
    public partial class Resposta_Correta : Form
    {
        public Resposta_Correta()
        {
            InitializeComponent();
        }
        private void Resposta_Correta_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 3000;
           // Voz.select(label1.Text + label2.Text);
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resposta_Correta_Shown_1(object sender, EventArgs e)
        {
           // Voz.select(label1.Text + label2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
