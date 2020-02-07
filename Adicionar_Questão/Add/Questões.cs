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

namespace Add
{
    public partial class Questões : Form
    {
        int count = 1;
        int i = BD.nha();
        public string gabarito;
        public string p_tr;
        public string a1_tr;
        public string a2_tr;
        public string a3_tr;
        public string a4_tr;
        public string a5_tr;
        public string dis, top;
        public string q;
        public bool menu = false;
        public Questões()
        {
            InitializeComponent();
            label1.ForeColor = System.Drawing.Color.Yellow;
            
        }
       

        private void Questões_Load(object sender, EventArgs e)
        {
            string c = BD.push();
            string[] campo = c.Split(';');
            label1.Text = campo[0].ToString().Substring(2);
            label2.Text = campo[1].ToString();
            label3.Text = campo[2].ToString();
            label4.Text = campo[3].ToString();
            label5.Text = campo[4].ToString();
            label6.Text = campo[5].ToString();
            gabarito = campo[6].ToString();
            a1_tr = campo[0].ToString();
            a2_tr = campo[1].ToString();
            a3_tr = campo[2].ToString();
            a4_tr = campo[3].ToString();
            a5_tr = campo[4].ToString();
            q = campo[0][0].ToString();
            this.Show();
           // Voz.select("Questão " + q + ":" + label1.Text);


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Questões_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Questões_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Questões_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                menu = false;
                if (label1.ForeColor == Color.Yellow)
                {
                    //label1.ForeColor = System.Drawing.Color.Lime;
                    label1.ForeColor = Color.Lime;
                    label2.ForeColor = Color.Yellow;
                    Voz.select("Questão " + q + ":" + label1.Text);
                }
                else if (label2.ForeColor == Color.Yellow)
                {
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.Yellow;
                    // Voz.select(a2_tr);
                }
                else if (label3.ForeColor == Color.Yellow)
                {
                    label3.ForeColor = System.Drawing.Color.White;
                    label4.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(a3_tr);
                }
                else if (label4.ForeColor == Color.Yellow)
                {
                    label4.ForeColor = System.Drawing.Color.White;
                    label5.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(a4_tr);
                }
                else if (label5.ForeColor == Color.Yellow)
                {
                    label5.ForeColor = System.Drawing.Color.White;
                    label6.ForeColor = System.Drawing.Color.Yellow;
                    //.select(a5_tr);
                }
                else if (label6.ForeColor == Color.Yellow)
                {
                    label6.ForeColor = System.Drawing.Color.White;
                    label1.ForeColor = System.Drawing.Color.Yellow;
                    // Voz.select(p_tr);
                }
                else if (Back.ForeColor == Color.Yellow)
                {
                    Back.ForeColor = System.Drawing.Color.White;
                    label1.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(p_tr);
                }
                else if (Main.ForeColor == Color.Yellow)
                {
                    Main.ForeColor = System.Drawing.Color.White;
                    label1.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(p_tr);
                }
                else if (Next.ForeColor == Color.Yellow)
                {
                    Next.ForeColor = System.Drawing.Color.White;
                    label1.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(p_tr);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                menu = false;
                if (label1.ForeColor == Color.Yellow)
                {
                    label1.ForeColor = System.Drawing.Color.Lime;
                    label6.ForeColor = System.Drawing.Color.Yellow;
                    // Voz.select(a5_tr);
                }

                else if (label2.ForeColor == Color.Yellow)
                {
                    label2.ForeColor = System.Drawing.Color.White;
                    label1.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(p_tr);
                }
                else if (label3.ForeColor == Color.Yellow)
                {
                    label3.ForeColor = System.Drawing.Color.White;
                    label2.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(a1_tr);
                }
                else if (label4.ForeColor == Color.Yellow)
                {
                    label4.ForeColor = System.Drawing.Color.White;
                    label3.ForeColor = System.Drawing.Color.Yellow;
                    // Voz.select(a2_tr);
                }
                else if (label5.ForeColor == Color.Yellow)
                {
                    label5.ForeColor = System.Drawing.Color.White;
                    label4.ForeColor = System.Drawing.Color.Yellow;
                    //Voz.select(a3_tr);
                }
                else if (label6.ForeColor == Color.Yellow)
                {
                    label6.ForeColor = System.Drawing.Color.White;
                    label5.ForeColor = System.Drawing.Color.Yellow;
                    /// Voz.select(a4_tr);
                }
                else if (Back.ForeColor == Color.Yellow)
                {
                    label6.ForeColor = System.Drawing.Color.Yellow;
                    Back.ForeColor = Color.White;
                    // Voz.select(p_tr);
                }
                else if (Main.ForeColor == Color.Yellow)
                {
                    label6.ForeColor = System.Drawing.Color.Yellow;
                    Main.ForeColor = Color.White;
                    //  label8.ForeColor = System.Drawing.Color.White;
                    // Voz.select(p_tr);
                }
                else if (Next.ForeColor == Color.Yellow)
                {
                    label6.ForeColor = System.Drawing.Color.Yellow;
                    Next.ForeColor = Color.White;
                    //  label8.ForeColor = System.Drawing.Color.White;
                    // Voz.select(p_tr);
                }

            }
            else if (e.KeyCode == Keys.Right)
            {
                label1.ForeColor = System.Drawing.Color.Lime;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;

                if (Next.ForeColor == Color.White && Back.ForeColor == Color.White && Main.ForeColor == Color.White)
                {
                    Next.ForeColor = System.Drawing.Color.Yellow;

                    Back.ForeColor = System.Drawing.Color.White;
                    Main.ForeColor = System.Drawing.Color.White;
                    // menu = true;
                }
                else if (Main.ForeColor == Color.Yellow)
                {
                    Next.ForeColor = System.Drawing.Color.White;

                    Back.ForeColor = System.Drawing.Color.Yellow;
                    Main.ForeColor = System.Drawing.Color.White;
                }
                else if (Back.ForeColor == Color.Yellow)
                {
                    Main.ForeColor = System.Drawing.Color.White;

                    Back.ForeColor = System.Drawing.Color.White;
                    Next.ForeColor = System.Drawing.Color.Yellow;
                }

                //  Voz.select("Tecle enter para a próxima questão");
            }
            else if (e.KeyCode == Keys.Left)
            {
                label1.ForeColor = System.Drawing.Color.Lime;
                label2.ForeColor = System.Drawing.Color.White;
                label3.ForeColor = System.Drawing.Color.White;
                label4.ForeColor = System.Drawing.Color.White;
                label5.ForeColor = System.Drawing.Color.White;
                label6.ForeColor = System.Drawing.Color.White;
                if (Next.ForeColor == Color.White && Back.ForeColor == Color.White && Main.ForeColor == Color.White)
                {
                    Back.ForeColor = System.Drawing.Color.Yellow;

                    Main.ForeColor = System.Drawing.Color.White;
                    Next.ForeColor = System.Drawing.Color.White;
                    // menu = true;
                }


                else if (Back.ForeColor == Color.Yellow && menu == false)
                {
                    Back.ForeColor = System.Drawing.Color.White;

                    Main.ForeColor = System.Drawing.Color.Yellow;
                    Next.ForeColor = System.Drawing.Color.White;
                    //menu = true;
                }

                else if (Next.ForeColor == Color.Yellow)
                {
                    Main.ForeColor = System.Drawing.Color.White;

                    Back.ForeColor = System.Drawing.Color.Yellow;
                    Next.ForeColor = System.Drawing.Color.White;
                }

                // Voz.select("Tecle enter para voltar a questão anterior");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (label2.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (gabarito == " A)")
                    {
                        Resposta_Correta abrir = new Resposta_Correta();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        Resposta_Errada abrir = new Resposta_Errada(gabarito);
                        abrir.ShowDialog();
                    }
                }
                else if (label3.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (gabarito == " B)")
                    {
                        Resposta_Correta abrir = new Resposta_Correta();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        Resposta_Errada abrir = new Resposta_Errada(gabarito);
                        abrir.ShowDialog();
                    }

                }
                else if (label4.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (gabarito == " C)")
                    {
                        Resposta_Correta abrir = new Resposta_Correta();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        Resposta_Errada abrir = new Resposta_Errada(gabarito);
                        abrir.ShowDialog();
                    }

                }
                else if (label5.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (gabarito == " D)")
                    {
                        Resposta_Correta abrir = new Resposta_Correta();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        Resposta_Errada abrir = new Resposta_Errada(gabarito);
                        abrir.ShowDialog();
                    }

                }
                else if (label6.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (gabarito == " E)")
                    {
                        Resposta_Correta abrir = new Resposta_Correta();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        Resposta_Errada abrir = new Resposta_Errada(gabarito);
                        abrir.ShowDialog();
                    }

                }
                else if (Back.ForeColor == System.Drawing.Color.Yellow)
                {
                    if (BD.j > 0)
                    {
                        BD.j--;

                        string x = BD.push();
                        string[] alor = x.Split(';');
                        label1.Text = alor[0];
                        label2.Text = alor[1];
                        label3.Text = alor[2];
                        label4.Text = alor[3];
                        label5.Text = alor[4];
                        label6.Text = alor[5];
                        gabarito = alor[6];
                        p_tr = label1.Text;
                        a1_tr = label2.Text;
                        a2_tr = label3.Text;
                        a3_tr = label4.Text;
                        a4_tr = label5.Text;
                        a5_tr = label6.Text;
                        label1.ForeColor = System.Drawing.Color.Yellow;
                        label2.ForeColor = System.Drawing.Color.White;
                        label3.ForeColor = System.Drawing.Color.White;
                        label4.ForeColor = System.Drawing.Color.White;
                        label5.ForeColor = System.Drawing.Color.White;
                        label6.ForeColor = System.Drawing.Color.White;
                        Back.ForeColor = System.Drawing.Color.White;
                        Main.ForeColor = System.Drawing.Color.White;
                        //Voz.select(p_tr);
                    }
                }
                else if (Next.ForeColor == System.Drawing.Color.Yellow)
                {
                    // MessageBox.Show(BD.cont[BD.j].ToString());
                    if (BD.j + 1 < BD.z)
                    {
                        BD.j++;
                        string x = BD.push();
                        string[] alor = x.Split(';');
                        label1.Text = alor[0];
                        label2.Text = alor[1];
                        label3.Text = alor[2];
                        label4.Text = alor[3];
                        label5.Text = alor[4];
                        label6.Text = alor[5];
                        gabarito = alor[6];
                        p_tr = label1.Text;
                        a1_tr = label2.Text;
                        a2_tr = label3.Text;
                        a3_tr = label4.Text;
                        a4_tr = label5.Text;
                        a5_tr = label6.Text;
                        label1.ForeColor = System.Drawing.Color.Yellow;
                        label2.ForeColor = System.Drawing.Color.White;
                        label3.ForeColor = System.Drawing.Color.White;
                        label4.ForeColor = System.Drawing.Color.White;
                        label5.ForeColor = System.Drawing.Color.White;
                        label6.ForeColor = System.Drawing.Color.White;
                        Back.ForeColor = System.Drawing.Color.White;
                        Main.ForeColor = System.Drawing.Color.White;
                        Next.ForeColor = System.Drawing.Color.White;
                        // Voz.select(p_tr);

                    }


                }
                else if (Main.ForeColor == System.Drawing.Color.Yellow)
                {

                    this.Hide();
                    Form f = new Menu_de_Questões();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

            }
            foreach (Label label in this.Controls.OfType<Label>())//ler
            {

                if (label.ForeColor == Color.Yellow)
                {
                    Voz.select(label.Text);
                }

            }
        }

        private void Questões_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        }

    

    }
