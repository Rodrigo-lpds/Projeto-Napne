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
//Login:estagio.napne5@gmail.com
//Senha:21345napne

namespace Estágio
{
    public partial class INVOIX : Form
    {
        public INVOIX()
             
        {
            InitializeComponent();
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
           
            int hour = DateTime.Now.Hour;
            if (hour >= 07 && hour < 12)
                synth.SpeakAsync("I N Voix, Good Morning! What do you need?");
            else if (hour >= 12 && hour < 19)
                synth.SpeakAsync("I N Voix, Good Afternoon!What do you need?");
            else if (hour >= 19)
                synth.SpeakAsync("I N Voix, Good Evening!What do you need?");
            else if (hour < 7)
                synth.SpeakAsync("I N Voix, Good Night!What do you need?");
        }
        public bool mouseleave = false;
        private void label1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 07 && hour < 12)
                label10.Text = "Bom Dia";
            else if (hour >= 12 && hour < 19)
                label10.Text = "Boa Tarde";
            else if (hour >= 19)
                label10.Text = "Boa Noite";
            else if (hour < 7)
                label10.Text = "Boa Noite";
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
           /*
            BoaVisão bv = new BoaVisão();
            bv.ShowDialog();
            bv.Focus();*/
            this.Hide();

            BoaVisão bv = new BoaVisão();
            bv.ShowDialog(); // Substituindo o Show()

            this.Close();
            this.Dispose();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           
           
        }

        private void label10_Load(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Load(object sender, PaintEventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 07 && hour < 12)
                label10.Text = "Bom Dia";
            else if (hour >= 12 && hour < 19)
                label10.Text = "Boa Tarde";
            else if (hour >= 19)
                label10.Text = "Boa Noite";
            else if (hour < 7)
                label10.Text = "Boa Noite";
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Move(object sender, EventArgs e)
        {
            
        }

        private void label1_Leave(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label1_Enter(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, MouseEventArgs e)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SetOutputToDefaultAudioDevice();
            //synth.SpeakAsync("I N Voix, Good Night!");
            //int hour = DateTime.Now.Hour;
            //if (hour >= 07 && hour < 12)
            //    synth.SpeakAsync("I N Voix, Good Morning!");
            //else if (hour >= 12 && hour < 19)
            //    synth.SpeakAsync("I N Voix, Good Afternoon!");
            //else if (hour >= 19)
            //    synth.SpeakAsync("I N Voix, Good Evening!");
            //else if (hour < 7)
            //    synth.SpeakAsync("I N Voix, Good Night!");


        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            mouseleave = true;

            if (mouseleave == true)
            {


                int hour = DateTime.Now.Hour;
                if (hour >= 07 && hour < 12)
                    label1.Text = "Bom Dia";
                else if (hour >= 12 && hour < 19)
                    label1.Text = "Boa Tarde";
                else if (hour >= 19)
                    label1.Text = "Boa Noite";
                else if (hour < 7)
                    label1.Text = "Boa Noite";

            }
            mouseleave = false;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            //mouseleave = true;

            //if (mouseleave == true)
            //{
                         

            //     int hour = DateTime.Now.Hour;
            //     if (hour >= 07 && hour < 12)
            //        label1.Text = "Bom Dia";
            //     else if (hour >= 12 && hour < 19)
            //        label1.Text = "Boa Tarde";
            //     else if (hour >= 19)
            //        label1.Text = "Boa Noite";
            //     else if (hour < 7)
            //        label1.Text = "Boa Noite";

            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            mouseleave = false;
            label1.Text = "IN VOIX";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseleave = false;
            label1.Text = "IN VOIX";
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            mouseleave = false;
            label1.Text = "IN VOIX";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
                    {
            if (e.KeyCode == Keys.Up)
            {
                
                button2_Click(sender, e);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
