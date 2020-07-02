namespace Genomium
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gvDados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PapelBiologico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosiçãoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosiçãoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SequenciaDNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDados
            // 
            this.gvDados.AllowUserToAddRows = false;
            this.gvDados.AllowUserToOrderColumns = true;
            this.gvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Gene,
            this.Tipo,
            this.Familia,
            this.PapelBiologico,
            this.PosiçãoInicial,
            this.PosiçãoFinal,
            this.SequenciaDNA});
            this.gvDados.Location = new System.Drawing.Point(12, 41);
            this.gvDados.Name = "gvDados";
            this.gvDados.ReadOnly = true;
            this.gvDados.Size = new System.Drawing.Size(737, 462);
            this.gvDados.TabIndex = 0;
            this.gvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDados_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Gene
            // 
            this.Gene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gene.DataPropertyName = "Gene";
            this.Gene.HeaderText = "Gene";
            this.Gene.Name = "Gene";
            this.Gene.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Familia
            // 
            this.Familia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Familia.DataPropertyName = "Familia";
            this.Familia.HeaderText = "Família";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            // 
            // PapelBiologico
            // 
            this.PapelBiologico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PapelBiologico.DataPropertyName = "PapelBiologico";
            this.PapelBiologico.HeaderText = "Papel Biológico";
            this.PapelBiologico.Name = "PapelBiologico";
            this.PapelBiologico.ReadOnly = true;
            // 
            // PosiçãoInicial
            // 
            this.PosiçãoInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PosiçãoInicial.DataPropertyName = "PosicaoInicial";
            this.PosiçãoInicial.HeaderText = "Posição Inicial";
            this.PosiçãoInicial.Name = "PosiçãoInicial";
            this.PosiçãoInicial.ReadOnly = true;
            // 
            // PosiçãoFinal
            // 
            this.PosiçãoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PosiçãoFinal.DataPropertyName = "PosicaoFinal";
            this.PosiçãoFinal.HeaderText = "Posição Final";
            this.PosiçãoFinal.Name = "PosiçãoFinal";
            this.PosiçãoFinal.ReadOnly = true;
            // 
            // SequenciaDNA
            // 
            this.SequenciaDNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SequenciaDNA.DataPropertyName = "SequenciaDNA";
            this.SequenciaDNA.HeaderText = "Sequencia DNA";
            this.SequenciaDNA.Name = "SequenciaDNA";
            this.SequenciaDNA.ReadOnly = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportar.Location = new System.Drawing.Point(12, 509);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(66, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.Location = new System.Drawing.Point(84, 509);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(53, 23);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.gvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "MainForm";
            this.Text = "Genomium";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDados;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PapelBiologico;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosiçãoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosiçãoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenciaDNA;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnInfo;
    }
}

