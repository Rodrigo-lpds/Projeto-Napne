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
    public partial class FÍSICA_DV2 : Form
    {
        public FÍSICA_DV2()
        {
            InitializeComponent();
        }

        private void FÍSICA_DV2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Física_DV qd = new Física_DV();
            qd.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {

                    button1_Click(sender, e);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Física_DV es = new Física_DV();
            es.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyUp_1(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {

                    button1_Click(sender, e);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            fisica_DV3 es = new fisica_DV3();
            es.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Right)
                {

                    button3_Click(sender, e);
                }
            }
        }
    }
}
