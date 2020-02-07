using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add
{
    
   
    public partial class Menu_de_Questões : Form
    {
        public static string pastor;
        public Menu_de_Questões()
        {
            InitializeComponent();
            label1.ForeColor = System.Drawing.Color.Yellow;
        }

        private void Menu_de_Questões_KeyDown(object sender, KeyEventArgs e)
        {
            

        }
        bool enter=false;
        int v = 0;
        string palavra;
        int i = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)//TECLA SUPREMA
        {
            if (keyData == Keys.Enter) // tecla para cima 
            {
               
                enter = true;
               
                listBox1.Focus();


                if (i == 0)
                {
                    if (label1.ForeColor == Color.Yellow)
                    {

                        listBox1.Items.Clear();
                        BD.execute("select tópico from Tópicos where disciplina = '" + "Matemática" + "'");
                        try
                        {
                            while (BD.leitor.Read())
                            {

                                listBox1.Items.Add(BD.leitor.GetString(0));
                            }
                            pastor = "Matemática";
                            listBox1.SelectedIndex = 0;
                            listBox1.Items.Add("Selecionar outra Disciplina");
                            
                        }
                        

                        catch
                        {
                            MessageBox.Show("erro");

                        }
                        
                    }
                    else if (label2.ForeColor == Color.Yellow)
                    {

                        listBox1.Items.Clear();
                        BD.execute("select tópico from Tópicos where disciplina = '" + "Física" + "'");
                        try
                        {
                            while (BD.leitor.Read())
                            {

                                listBox1.Items.Add(BD.leitor.GetString(0));
                            }
                            pastor = "Física";
                            listBox1.SelectedIndex = 0;
                            listBox1.Items.Add("Selecionar outra Disciplina");

                        }

                        catch
                        {
                            MessageBox.Show("erro");

                        }
                      
                    }
                    else if (label3.ForeColor == Color.Yellow)
                    {

                        listBox1.Items.Clear();
                        BD.execute("select tópico from Tópicos where disciplina = '" + "Química" + "'");
                        try
                        {
                            while (BD.leitor.Read())
                            {

                                listBox1.Items.Add(BD.leitor.GetString(0));
                            }
                            pastor = "Química";
                            listBox1.SelectedIndex = 0;
                            listBox1.Items.Add("Selecionar outra Disciplina");

                        }

                        catch
                        {
                            MessageBox.Show("erro");

                        }
                      
                    }
                }
                else if (i >= 1)
                {
                    if (palavra != null && palavra != "Selecionar outra Disciplina")
                    {
                        //if (palavra == "Gravidade")
                        // {
                        if (label1.ForeColor == Color.Yellow)
                        {
                            BD.dis = label1.Text;
                            BD.top = palavra;
                        }
                        else if (label2.ForeColor == Color.Yellow)
                        {
                            BD.dis = label2.Text;
                            BD.top = palavra;
                        }
                        else if (label3.ForeColor == Color.Yellow)
                        {
                            BD.dis = label3.Text;
                            BD.top = palavra;
                        }


                        this.Hide();
                        Form f = new Questões();
                        f.Closed += (s, args) => this.Close();
                        f.Show();
                       

                        //}
                    }
                    else if (palavra == "Selecionar outra Disciplina")
                    {
                        enter = false;
                        label2.ForeColor = Color.White;
                        label3.ForeColor = Color.White;
                        label1.ForeColor = Color.Yellow;

                        i = 0;


                    }
                }
              
            }
            if (enter == false)
            {
                if (keyData == Keys.Up) // tecla para cima 
                {


                    if (label1.ForeColor == Color.Yellow)
                    {
                        label1.ForeColor = System.Drawing.Color.White;
                        label3.ForeColor = System.Drawing.Color.Yellow;


                    }
                    else if (label2.ForeColor == Color.Yellow)
                    {
                        label2.ForeColor = System.Drawing.Color.White;
                        label1.ForeColor = System.Drawing.Color.Yellow;

                    }
                    else if (label3.ForeColor == Color.Yellow)
                    {
                        label3.ForeColor = System.Drawing.Color.White;
                        label2.ForeColor = System.Drawing.Color.Yellow;



                    }

                }
            }
            if (enter == false)
            {
                if (keyData == Keys.Down) //tecla pra baixo
                {
                    if (enter == false)
                    {
                        if (label1.ForeColor == Color.Yellow)
                        {
                            label1.ForeColor = System.Drawing.Color.White;
                            label2.ForeColor = System.Drawing.Color.Yellow;

                        }
                        else if (label2.ForeColor == Color.Yellow)
                        {
                            label2.ForeColor = System.Drawing.Color.White;
                            label3.ForeColor = System.Drawing.Color.Yellow;

                        }
                        else if (label3.ForeColor == Color.Yellow)
                        {
                            label3.ForeColor = System.Drawing.Color.White;
                            label1.ForeColor = System.Drawing.Color.Yellow;
                        }
                    }
                }
            }



            else
                return base.ProcessCmdKey(ref msg, keyData);
            return true;
        }//FIM DA TECLA SUPREMA
    
        private void button1_Click(object sender, EventArgs e)
        {
            Questões abrir = new Questões();
            abrir.ShowDialog();
            this.Close();
        }

        private void Menu_de_Questões_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    BD.execute("Select count(cod_q) from ")
            //}
            //if()
        }

        private void Menu_de_Questões_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i++;
            palavra = listBox1.SelectedItem.ToString();
        }

        private void Menu_de_Questões_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
