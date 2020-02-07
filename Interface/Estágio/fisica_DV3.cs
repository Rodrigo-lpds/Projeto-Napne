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
    public partial class fisica_DV3 : Form
    {
        public fisica_DV3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            FÍSICA_DV2 es = new FÍSICA_DV2();
            es.ShowDialog();

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
    }
}
