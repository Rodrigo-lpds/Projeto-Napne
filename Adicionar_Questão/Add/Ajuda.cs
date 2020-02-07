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
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void Ajuda_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Sinal_Matematico", "Sinal Matemático");
            dataGridView1.Columns.Add("Significado", "Significado");
            dataGridView1.Rows.Add("+", "adição");
            dataGridView1.Rows.Add("-", "subtração");
            dataGridView1.Rows.Add("*", "multiplicação");
            dataGridView1.Rows.Add("/", "divisão");
            dataGridView1.Rows.Add("=", "igualdade");
            dataGridView1.Rows.Add(">", "maior que");
            dataGridView1.Rows.Add("<", "menor que");
            dataGridView1.Rows.Add(">=", "maior ou igual a");
            dataGridView1.Rows.Add("<=", "menor ou igual a");
            dataGridView1.Rows.Add("(", "abre parênteses");
            dataGridView1.Rows.Add(")", "fecha parênteses");
            dataGridView1.Rows.Add("{", "abre chaves");
            dataGridView1.Rows.Add("}", "fecha chaves");
            dataGridView1.Rows.Add("[", "abre colchetes");
            dataGridView1.Rows.Add("]", "fecha colchetes");
            dataGridView1.Rows.Add("%", "por cento");
            dataGridView1.Rows.Add("§", "raiz quadrada");
            dataGridView1.Rows.Add("pi(3,1415...)", "pi");
            dataGridView1.Rows.Add("//", "sobre ( fração ) ");
        }

        private void Ajuda_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
