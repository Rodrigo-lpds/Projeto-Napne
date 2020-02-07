using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Estágio
{
    public partial class MatQ : Form
    {
        public List<Label> a = new List<Label>();
        public Label[] labels;
        public int labelcount = 0, labelcount2 = 0, mirror = -1;
        public string i;

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public MatQ()
        {
            InitializeComponent();
        }
        private void MatQ_Load(object sender, EventArgs e)
        {

            foreach (Label i in this.Controls.OfType<Label>())
            {

                a.Add(i);
                labelcount2++;
                mirror++;
            }
            labels = a.ToArray();


            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            //foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            //{
            //    VoiceInfo voice1 = voice.VoiceInfo;
            //    comboBox1.Items.Add(voice1.Name);
            //}
        }
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    //if (keyData == Keys.Enter) // tecla para cima 
        //    //{
        //    //    if (label1.ForeColor != Color.White)
        //    //    {
        //    //        MatQ1 abrir = new MatQ1();
        //    //        abrir.ShowDialog();

        //    //        this.Hide();
        //    //        this.Close();
        //    //        this.Dispose();
        //    //    }
        //    //    else if (label4.ForeColor != Color.White)
        //    //    {
        //    //        this.Hide();

        //    //        MatQ abrir = new MatQ();
        //    //        abrir.ShowDialog();

        //    //        this.Close();
        //    //        this.Dispose();
        //    //    }
        //    //}


        //    //if (keyData == Keys.Up) // tecla para cima 
        //    //{
        //    //    foreach (Label label in this.Controls.OfType<Label>())
        //    //    {
        //    //        label.ForeColor = Color.White;
        //    //    }

        //    //    labelcount2++;

        //    //    if (labelcount2 > mirror)
        //    //        labelcount2 = 0;

        //    //    foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
        //    //    {
        //    //        label.ForeColor = Color.Yellow;

        //    //    }
        //    //    if (label1.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label1.Text);
        //    //    else if (label2.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label2.Text);
        //    //    else if (label3.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label3.Text);
        //    //    else if (label4.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label4.Text);


        //    //    return true; //for the active control to see the keypress, return false
        //    //}
        //    //else if (keyData == Keys.Down) //tecla pra baixo
        //    //{


        //    //    foreach (Label label in this.Controls.OfType<Label>())
        //    //    {
        //    //        label.ForeColor = Color.White;
        //    //    }

        //    //    labelcount2--;
        //    //    if (labelcount2 < 0)
        //    //        labelcount2 = mirror;
        //    //    foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
        //    //    {
        //    //        label.ForeColor = Color.Yellow;
        //    //    }

        //    //    if (label1.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label1.Text);
        //    //    else if (label2.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label2.Text);
        //    //    else if (label3.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label3.Text);
        //    //    else if (label4.ForeColor != Color.White)
        //    //        synthesizer.SpeakAsync(label4.Text);


        //    //    return true; //for the active control to see the keypress, return false
        //    //}
        //    //else
        //    //    return base.ProcessCmdKey(ref msg, keyData);
        //}

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            //MatQ1 abrir = new MatQ1();
            //abrir.ShowDialog();
        }
    }
}

