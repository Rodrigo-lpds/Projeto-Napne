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
    public partial class Física_DV : Form
    {
        public List<Label> a = new List<Label>();
        public Label[] labels;
        public int labelcount = 0, labelcount2 = 0, mirror = -1;
        public string i;
        public Física_DV()
        {
            InitializeComponent();
        }

      /*  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) // tecla para cima 
            {
                if (label1.ForeColor != Color.White)
                {
                    this.Hide();

                    Form1 fr = new Form1();
                    fr.ShowDialog();


                    this.Close();
                    this.Dispose();

                }
            }


            if (keyData == Keys.Up) // tecla para cima 
            {
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }

                label1.ForeColor = Color.Lime;
                label2.ForeColor = Color.Aquamarine;
                label3.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
                label11.ForeColor = Color.Yellow;
                label15.ForeColor = Color.Yellow;
                label20.ForeColor = Color.Yellow;
                label24.ForeColor = Color.Yellow;
                label29.ForeColor = Color.Yellow;

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
                label2.ForeColor = Color.Aquamarine;
                label3.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
                label11.ForeColor = Color.Yellow;
                label15.ForeColor = Color.Yellow;
                label20.ForeColor = Color.Yellow;
                label24.ForeColor = Color.Yellow;
                label29.ForeColor = Color.Yellow;

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
        }*/
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Física_DV_Load(object sender, EventArgs e)
        {
            foreach (Label i in this.Controls.OfType<Label>())
            {

                a.Add(i);
                labelcount2++;
                mirror++;
            }
            labels = a.ToArray();
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            FÍSICA_DV2 qm2 = new FÍSICA_DV2();
            qm2.ShowDialog();


            this.Close();
            this.Dispose();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FÍSICA_DV2 qd = new FÍSICA_DV2();
            qd.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Right)
                {

                    button2_Click(sender, e);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();

            //Especial es = new Especial();
            //es.ShowDialog();

            //this.Close();
            //this.Dispose();
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();

            Especial es = new Especial();
            es.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            FÍSICA_DV2 es = new FÍSICA_DV2();
            es.ShowDialog();

            this.Close();
            this.Dispose();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
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

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyUp_1(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Right)
                {

                    button2_Click(sender, e);
                }
            }
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
        
    }
}

