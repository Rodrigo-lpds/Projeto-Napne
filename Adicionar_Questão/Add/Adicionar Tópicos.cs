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
    public partial class Adicionar_Tópicos : Form
    {
        public Adicionar_Tópicos()
        {
            InitializeComponent();
        }
        public string tópico;
        public string var;
        
        private void Adicionar_Tópicos_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Matemática");
            comboBox1.Items.Add("Física");
            comboBox1.Items.Add("Química");

            if (Add_Q.verif == true)
            {
                comboBox1.SelectedItem = Add_Q.disciplina;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                BD.execute("insert into Tópicos values('" + comboBox1.SelectedItem.ToString() + "','" + textBox2.Text + "')");
                var = comboBox1.SelectedItem.ToString();
                tópico = textBox2.Text;
                
                textBox2.Clear();
                MessageBox.Show("Tópico adicionado com sucesso!");
                this.Hide();
                                
            }

            else
                MessageBox.Show("Selecione a disciplina");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Adicionar_Tópicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           
                
              
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
            
        
    }
}
