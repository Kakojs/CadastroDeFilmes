﻿using System;
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
            filmesTable.TableName = "Filmes";
            filmesTable.Columns.Add("Titulo", typeof(string));
            filmesTable.Columns.Add("Diretor", typeof(string));
            filmesTable.Columns.Add("Gênero", typeof(string));
            filmesTable.Columns.Add("Ano De Lançamento", typeof(int));
            filmesTable.Columns.Add("Duração", typeof(int));
            filmesTable.Columns.Add("Avaliação", typeof(int));

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = filmesTable;
            MessageBox.Show("DataTable vinculado ao DataGridView com sucesso!");



        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool colunaAdicionada = false;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        
        {
            if (!colunaAdicionada)
            {
                string nomeDaColuna = "Avalie";


                if (!dataGridView1.Columns.Contains("Avalie"))
                {
                    DataGridViewComboBoxColumn CheckedListBox = new DataGridViewComboBoxColumn();
                    CheckedListBox.HeaderText = "Avalie";
                    CheckedListBox.Items.AddRange("5", "4", "3", "2", "1");

                    dataGridView1.Columns.Add(CheckedListBox);
                    colunaAdicionada = true;
                }
            }
        }
        ///comentario teste 
        private void novoFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!filmesTable.Rows.Contains(""))
            {   
                
                filmesTable.Rows.Add();
            }
        }

        private void salvarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filmesTable.WriteXml(saveFileDialog.FileName);
                        MessageBox.Show("Dados salvos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
            }
            
        }
        private void carregarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filmesTable.Clear();
                        filmesTable.ReadXml(openFileDialog.FileName);
                    }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Erro ao importar dados: " + ex.Message);
            }
            
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



