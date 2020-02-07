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
    public partial class quimica_DV : Form
    {

        public List<Label> a = new List<Label>();
        public Label[] labels;
        public int labelcount = 0, labelcount2 = 0, mirror = -1;
        public string i;
        public quimica_DV()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) // tecla para cima 
            {
             
            }


            if (keyData == Keys.Up) // tecla para cima 
            {
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }

                label1.ForeColor = Color.Lime;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.White;

                label4.ForeColor = Color.White;
                
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.Yellow;
                label9.ForeColor = Color.Yellow;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;


                labelcount2++;

                if (labelcount2 > mirror)
                    labelcount2 = 0;

                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.Red;
                }

                return true; //for the active control to see the keypress, return false
            }
            else if (keyData == Keys.Down) //tecla pra baixo
            {


                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }
                label1.ForeColor = Color.Lime;
                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.White;

                label4.ForeColor = Color.White;
                
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.Yellow;
                label9.ForeColor = Color.Yellow;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                




                labelcount2--;
                if (labelcount2 < 0)
                    labelcount2 = mirror;
                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.Red;
                }



                return true; //for the active control to see the keypress, return false
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void quimica_DV_Load(object sender, EventArgs e)
        {
            foreach (Label i in this.Controls.OfType<Label>())
            {

                a.Add(i);
                labelcount2++;
                mirror++;
            }
            labels = a.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            quimica_DV2 qm = new quimica_DV2();
            qm.ShowDialog();

            this.Close();
            this.Dispose();

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Right)
                {

                    button1_Click(sender, e);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Especial es = new Especial();
            es.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {

                    button2_Click(sender, e);
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Especial es = new Especial();
            es.ShowDialog();


            this.Close();
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            quimica_DV2 qm2 = new quimica_DV2();
            qm2.ShowDialog();


            this.Close();
            this.Dispose();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
