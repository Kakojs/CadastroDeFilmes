namespace CadastroDeFilmes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoDeLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaliação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFilmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoFilmeToolStripMenuItem
            // 
            this.novoFilmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarDadosToolStripMenuItem,
            this.salvarDadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.novoFilmeToolStripMenuItem.Name = "novoFilmeToolStripMenuItem";
            this.novoFilmeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.novoFilmeToolStripMenuItem.Text = "Novo Filme";
            this.novoFilmeToolStripMenuItem.Click += new System.EventHandler(this.novoFilmeToolStripMenuItem_Click);
            // 
            // carregarDadosToolStripMenuItem
            // 
            this.carregarDadosToolStripMenuItem.Name = "carregarDadosToolStripMenuItem";
            this.carregarDadosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.carregarDadosToolStripMenuItem.Text = "Carregar Dados";
            this.carregarDadosToolStripMenuItem.Click += new System.EventHandler(this.carregarDadosToolStripMenuItem_Click);
            // 
            // salvarDadosToolStripMenuItem
            // 
            this.salvarDadosToolStripMenuItem.Name = "salvarDadosToolStripMenuItem";
            this.salvarDadosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.salvarDadosToolStripMenuItem.Text = "Salvar Dados";
            this.salvarDadosToolStripMenuItem.Click += new System.EventHandler(this.salvarDadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Diretor,
            this.Genero,
            this.AnoDeLancamento,
            this.Duracao,
            this.Avaliação});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 58;
            // 
            // Diretor
            // 
            this.Diretor.Frozen = true;
            this.Diretor.HeaderText = "Diretor";
            this.Diretor.MinimumWidth = 6;
            this.Diretor.Name = "Diretor";
            this.Diretor.Width = 63;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 67;
            // 
            // AnoDeLancamento
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Format = "dd/dd/dddd";
            this.AnoDeLancamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.AnoDeLancamento.DividerWidth = 2;
            this.AnoDeLancamento.HeaderText = "Ano de Lançamento ";
            this.AnoDeLancamento.MinimumWidth = 6;
            this.AnoDeLancamento.Name = "AnoDeLancamento";
            this.AnoDeLancamento.Width = 122;
            // 
            // Duracao
            // 
            this.Duracao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Duracao.HeaderText = "Duração (em minutos)";
            this.Duracao.MinimumWidth = 6;
            this.Duracao.Name = "Duracao";
            this.Duracao.Width = 124;
            // 
            // Avaliação
            // 
            this.Avaliação.HeaderText = "De sua opinião";
            this.Avaliação.MinimumWidth = 6;
            this.Avaliação.Name = "Avaliação";
            this.Avaliação.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Avaliação.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Avaliação.Width = 76;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1177, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diretor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoDeLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaliação;
    }
}

