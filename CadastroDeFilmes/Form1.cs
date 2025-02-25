using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeFilmes
{
    public partial class Form1 : Form
    {
        private DataTable filmesTable;
        public Form1()
        {
            InitializeComponent();
            InicializarDataTable();
        }
        private void InicializarDataTable()
        {
            filmesTable = new DataTable();
            filmesTable.Columns.Add("Titulo", typeof(string));
            filmesTable.Columns.Add("Diretor", typeof(string));
            filmesTable.Columns.Add("Genero", typeof(string));
            filmesTable.Columns.Add("Ano De Lançamento", typeof(int));
            filmesTable.Columns.Add("Duração", typeof(int));
            filmesTable.Columns.Add("Avaliação", typeof(int));

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
