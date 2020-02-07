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
    public partial class Math : Form
    {
        int count = 1;
        int i = BD.nha();
        public Math()
        {
            InitializeComponent();
        }

        private void Math_Load(object sender, EventArgs e)
        {
          
            string x = BD.push(1);
            string[] alor = x.Split(';');
            label1.Text = alor[0];
            label2.Text = alor[1];
            label3.Text = alor[2];
            label4.Text = alor[3];
            label5.Text = alor[4];
            label6.Text = alor[5];
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        
            if (count < i) { count = count + 1; }
            string x = BD.push(count);
            string[] alor = x.Split(';');
            label1.Text = alor[0];
            label2.Text = alor[1];
            label3.Text = alor[2];
            label4.Text = alor[3];
            label5.Text = alor[4];
            label6.Text = alor[5];
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if(count>1)count = count - 1;
            string x = BD.push(count);
            string[] alor = x.Split(';');
            label1.Text = alor[0];
            label2.Text = alor[1];
                 label3.Text = alor[2];
            label4.Text = alor[3];
             label5.Text = alor[4];
            label6.Text = alor[5];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        }
    }

