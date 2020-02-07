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
    public partial class Matemática_DV : Form
    {
        public Matemática_DV()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            INVOIX MATQ1 = new INVOIX();
            MATQ1.ShowDialog();


            this.Close();
            this.Dispose();
        }
    }
}
