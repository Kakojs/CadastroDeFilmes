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
            this.Avaliação = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1569, 28);
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
            this.novoFilmeToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.novoFilmeToolStripMenuItem.Text = "Novo Filme";
            this.novoFilmeToolStripMenuItem.Click += new System.EventHandler(this.novoFilmeToolStripMenuItem_Click);
            // 
            // carregarDadosToolStripMenuItem
            // 
            this.carregarDadosToolStripMenuItem.Name = "carregarDadosToolStripMenuItem";
            this.carregarDadosToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.carregarDadosToolStripMenuItem.Text = "Carregar Dados";
            this.carregarDadosToolStripMenuItem.Click += new System.EventHandler(this.carregarDadosToolStripMenuItem_Click);
            // 
            // salvarDadosToolStripMenuItem
            // 
            this.salvarDadosToolStripMenuItem.Name = "salvarDadosToolStripMenuItem";
            this.salvarDadosToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.salvarDadosToolStripMenuItem.Text = "Salvar Dados";
            this.salvarDadosToolStripMenuItem.Click += new System.EventHandler(this.salvarDadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Diretor,
            this.Genero,
            this.AnoDeLancamento,
            this.Duracao,
            this.Avaliação});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Diretor
            // 
            this.Diretor.Frozen = true;
            this.Diretor.HeaderText = "Diretor";
            this.Diretor.MinimumWidth = 6;
            this.Diretor.Name = "Diretor";
            this.Diretor.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // AnoDeLancamento
            // 
            this.AnoDeLancamento.HeaderText = "Ano de Lançamento ";
            this.AnoDeLancamento.MinimumWidth = 6;
            this.AnoDeLancamento.Name = "AnoDeLancamento";
            this.AnoDeLancamento.Width = 125;
            // 
            // Duracao
            // 
            this.Duracao.HeaderText = "Duração (em minutos)";
            this.Duracao.MinimumWidth = 6;
            this.Duracao.Name = "Duracao";
            this.Duracao.Width = 125;
            // 
            // Avaliação
            // 
            this.Avaliação.HeaderText = "Avaliação";
            this.Avaliação.MinimumWidth = 6;
            this.Avaliação.Name = "Avaliação";
            this.Avaliação.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Avaliação.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Avaliação;
    }
}

