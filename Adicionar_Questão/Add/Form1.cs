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
    public partial class Add_Q : Form
    {
        public int p = 1;
        public Add_Q()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox1.Focus();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox1.SelectedItem != "Selecione a Matéria " && comboBox2.SelectedItem != "Selecione o Gabarito")
            {
                
                //BDVoz.b = richTextBox3.Text.Replace("^", " elevado a ").Replace(">=", " maior ou igual a ").Replace("<=", " menor ou igual a ").Replace("<", " menor que ").Replace(">", " maior que ").Replace("(", " abre parênteses ").Replace(")", " fecha parênteses ").Replace("*", " multiplicado por ").Replace("/", " dividido por ").Replace("//", " sobre ").Replace("%", " por cento ").Replace("#", " raiz quadrada de ").Replace("[", " abre colchetes ").Replace("]", " fecha colchetes ").Replace("{", " abre chaves ").Replace("}", " fecha chaves ").Replace("§", " raiz quadrada de ");
               
                BD.x = comboBox1.SelectedItem.ToString();
                BD.g = comboBox2.SelectedItem.ToString();
                BD.qt = richTextBox1.Text;
                BD.a = richTextBox2.Text;
                BD.b = richTextBox3.Text;
                BD.c = richTextBox5.Text;
                BD.d = richTextBox4.Text;
                BD.e = richTextBox6.Text;
                BD.tz = comboBox3.SelectedItem.ToString();
                p = 2;
                
                

            }
            else
                MessageBox.Show("Preencha todos os campos");
          
            
            if (p == 2)
            {
                BD.insert();
                MessageBox.Show("Questão adicionada com sucesso!");
            }
            else
                MessageBox.Show("Preencha todos os campos");

           

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Q_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                comboBox3.Items.Add("Adicionar Tópico");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Ajuda ok = new Ajuda();
            ok.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Adicionar Tópico") 
            {
                Adicionar_Tópicos bbb = new Adicionar_Tópicos();
                bbb.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            if (comboBox1.SelectedItem != null)
            {
                BD.execute("select tópico from Tópicos where disciplina='" + comboBox1.SelectedItem.ToString() + "'");
                try
                {
                    while (BD.leitor.Read())
                    {
                        comboBox3.Items.Add(BD.leitor.GetString(0));

                    }

                }
                catch
                {
                    MessageBox.Show("erro");
                }

                comboBox3.Items.Add("Adicionar Tópico");
            }
        }
        
      
    }
}
