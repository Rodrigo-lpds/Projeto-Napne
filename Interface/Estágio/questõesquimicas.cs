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
    public partial class questõesquimicas : Form
    {
        public List<Label> a = new List<Label>();
        public Label[] labels;
        public int labelcount = 0, labelcount2 = 0, mirror = -1;
        public string i;
        public questõesquimicas()
        {
            InitializeComponent();
        }
       
       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) // tecla para cima 
            {
             
                this.Hide();

                Especial qd = new Especial();
                qd.ShowDialog();

                this.Close();
                this.Dispose();
            }


            if (keyData == Keys.Up) // tecla para cima 
            {
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }

                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Lime;
                label3.ForeColor = Color.Lime;

                label4.ForeColor = Color.Lime;
                label5.ForeColor = Color.Lime;
                label6.ForeColor = Color.Lime;
                label7.ForeColor = Color.Lime;
                label8.ForeColor = Color.Lime;
                label9.ForeColor = Color.Lime;
                label10.ForeColor = Color.Lime;
                label11.ForeColor = Color.Lime;
                label12.ForeColor = Color.Lime;
                label13.ForeColor = Color.Lime;
                label14.ForeColor = Color.Lime;
                label15.ForeColor = Color.Lime;
                label16.ForeColor = Color.Lime;
                label17.ForeColor = Color.Lime;
                label18.ForeColor = Color.Lime;
                label19.ForeColor = Color.Lime;
                label20.ForeColor = Color.Lime;
                label21.ForeColor = Color.Lime;
              
                




                labelcount2++;

                if (labelcount2 > mirror)
                    labelcount2 = 0;

                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.White;
                }

                return true; //for the active control to see the keypress, return false
            }
            else if (keyData == Keys.Down) //tecla pra baixo
            {


                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Lime;
                label3.ForeColor = Color.Lime;

                label4.ForeColor = Color.Lime;
                label5.ForeColor = Color.Lime;
                label6.ForeColor = Color.Lime;
                label7.ForeColor = Color.Lime;
                label8.ForeColor = Color.Lime;
                label9.ForeColor = Color.Lime;
                label10.ForeColor = Color.Lime;
                label11.ForeColor = Color.Lime;
                label12.ForeColor = Color.Lime;
                label13.ForeColor = Color.Lime;
                label14.ForeColor = Color.Lime;
                label15.ForeColor = Color.Lime;
                label16.ForeColor = Color.Lime;
                label17.ForeColor = Color.Lime;
                label18.ForeColor = Color.Lime;
                label19.ForeColor = Color.Lime;
                label20.ForeColor = Color.Lime;
                label21.ForeColor = Color.Lime;
                




                labelcount2--;
                if (labelcount2 < 0)
                    labelcount2 = mirror;
                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.White;
                }



                return true; //for the active control to see the keypress, return false
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            quimica_DV4 qd = new quimica_DV4();
            qd.ShowDialog();

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

        private void questõesquimicas_Load(object sender, EventArgs e)
        {
            foreach (Label i in this.Controls.OfType<Label>())
            {

                a.Add(i);
                labelcount2++;
                mirror++;
            }
            labels = a.ToArray();
        }

        private void label18_Click(object sender, EventArgs e)
        {
        
            
        }
    }
}
