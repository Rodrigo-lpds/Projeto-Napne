﻿using System;
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
    public partial class Física : Form
    {
        public Física()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            BoaVisão bv = new BoaVisão();
            bv.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            BoaVisão bv = new BoaVisão();
            bv.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
        }
    }
}
