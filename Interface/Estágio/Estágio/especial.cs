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
    public partial class Especial : Form
    {
        public List<Label> a = new List<Label>();
        public Label[] labels;
        public int labelcount = 0, labelcount2 = 0, mirror = -1;
        public string i;

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        
        public Especial()
        {
            
            InitializeComponent();
        }

        private void especial_Load(object sender, EventArgs e)
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


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
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

                labelcount2++;

                if (labelcount2 > mirror)
                    labelcount2 = 0;

                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.Yellow;
                
                }
                if (label1.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label1.Text);
                else if (label2.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label2.Text);
                else if (label3.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label3.Text);
                else if (label4.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label4.Text);
                
                                
                                return true; //for the active control to see the keypress, return false
            }
            else if (keyData == Keys.Down) //tecla pra baixo
            {


                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = Color.White;
                }

                labelcount2--;
                if (labelcount2 < 0)
                    labelcount2 = mirror;
                foreach (Label label in this.Controls.OfType<Label>().Where((item, index) => index == labelcount2))
                {
                    label.ForeColor = Color.Yellow;
                }

                if (label1.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label1.Text);
                else if (label2.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label2.Text);
                else if (label3.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label3.Text);
                else if (label4.ForeColor != Color.White)
                    synthesizer.SpeakAsync(label4.Text);
                
                
                return true; //for the active control to see the keypress, return false
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
        private void INÍCIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       


       
          private void Especial_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     
           

     

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

         
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

         
        }

        private void linkLabel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void Especial_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.Hide();

                Form1 fr = new Form1();
                fr.ShowDialog();


                this.Close();
                this.Dispose();
            }
        }

        private void Especial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 fr = new Form1();
            fr.ShowDialog();


            this.Close();
            this.Dispose();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //synthesizer.SelectVoice(comboBox1.SelectedItem.ToString());
        }
        

      
        }
      

    }

     
        


