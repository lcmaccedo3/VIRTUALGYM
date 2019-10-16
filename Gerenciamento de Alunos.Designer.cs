namespace VirtualGym
{
    partial class gerAluno
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
            this.components = new System.ComponentModel.Container();
            this.dtGridAluno = new System.Windows.Forms.DataGridView();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIRTUALGYMDataSet = new VirtualGym.VIRTUALGYMDataSet();
            this.alunoTableAdapter = new VirtualGym.VIRTUALGYMDataSetTableAdapters.alunoTableAdapter();
            this.btnPgto = new System.Windows.Forms.Button();
            this.btnFerias = new System.Windows.Forms.Button();
            this.btnIncAluno = new System.Windows.Forms.Button();
            this.btnAltAluno = new System.Windows.Forms.Button();
            this.btnVisAluno = new System.Windows.Forms.Button();
            this.btnExcAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridAluno
            // 
            this.dtGridAluno.AllowUserToAddRows = false;
            this.dtGridAluno.AllowUserToDeleteRows = false;
            this.dtGridAluno.AutoGenerateColumns = false;
            this.dtGridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dtGridAluno.DataSource = this.alunoBindingSource;
            this.dtGridAluno.Location = new System.Drawing.Point(12, 23);
            this.dtGridAluno.Name = "dtGridAluno";
            this.dtGridAluno.ReadOnly = true;
            this.dtGridAluno.Size = new System.Drawing.Size(607, 454);
            this.dtGridAluno.TabIndex = 0;
            this.dtGridAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "idAluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 480;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.vIRTUALGYMDataSet;
            // 
            // vIRTUALGYMDataSet
            // 
            this.vIRTUALGYMDataSet.DataSetName = "VIRTUALGYMDataSet";
            this.vIRTUALGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // btnPgto
            // 
            this.btnPgto.Location = new System.Drawing.Point(239, 507);
            this.btnPgto.Name = "btnPgto";
            this.btnPgto.Size = new System.Drawing.Size(203, 30);
            this.btnPgto.TabIndex = 1;
            this.btnPgto.Text = "Manutenção de Pagamento";
            this.btnPgto.UseVisualStyleBackColor = true;
            this.btnPgto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnFerias
            // 
            this.btnFerias.Location = new System.Drawing.Point(12, 507);
            this.btnFerias.Name = "btnFerias";
            this.btnFerias.Size = new System.Drawing.Size(203, 30);
            this.btnFerias.TabIndex = 2;
            this.btnFerias.Text = "Manutenção de Férias";
            this.btnFerias.UseVisualStyleBackColor = true;
            // 
            // btnIncAluno
            // 
            this.btnIncAluno.Location = new System.Drawing.Point(655, 23);
            this.btnIncAluno.Name = "btnIncAluno";
            this.btnIncAluno.Size = new System.Drawing.Size(123, 27);
            this.btnIncAluno.TabIndex = 3;
            this.btnIncAluno.Text = "Incluir";
            this.btnIncAluno.UseVisualStyleBackColor = true;
            this.btnIncAluno.Click += new System.EventHandler(this.BtnIncAluno_Click);
            // 
            // btnAltAluno
            // 
            this.btnAltAluno.Location = new System.Drawing.Point(655, 56);
            this.btnAltAluno.Name = "btnAltAluno";
            this.btnAltAluno.Size = new System.Drawing.Size(123, 27);
            this.btnAltAluno.TabIndex = 4;
            this.btnAltAluno.Text = "Alterar";
            this.btnAltAluno.UseVisualStyleBackColor = true;
            // 
            // btnVisAluno
            // 
            this.btnVisAluno.Location = new System.Drawing.Point(655, 89);
            this.btnVisAluno.Name = "btnVisAluno";
            this.btnVisAluno.Size = new System.Drawing.Size(123, 27);
            this.btnVisAluno.TabIndex = 5;
            this.btnVisAluno.Text = "Visualizar";
            this.btnVisAluno.UseVisualStyleBackColor = true;
            this.btnVisAluno.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnExcAluno
            // 
            this.btnExcAluno.Location = new System.Drawing.Point(655, 122);
            this.btnExcAluno.Name = "btnExcAluno";
            this.btnExcAluno.Size = new System.Drawing.Size(123, 27);
            this.btnExcAluno.TabIndex = 6;
            this.btnExcAluno.Text = "Excluir";
            this.btnExcAluno.UseVisualStyleBackColor = true;
            // 
            // gerAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 589);
            this.Controls.Add(this.btnExcAluno);
            this.Controls.Add(this.btnVisAluno);
            this.Controls.Add(this.btnAltAluno);
            this.Controls.Add(this.btnIncAluno);
            this.Controls.Add(this.btnFerias);
            this.Controls.Add(this.btnPgto);
            this.Controls.Add(this.dtGridAluno);
            this.Name = "gerAluno";
            this.Text = "Gerenciamento de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridAluno;
        private VIRTUALGYMDataSet vIRTUALGYMDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private VIRTUALGYMDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPgto;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Button btnIncAluno;
        private System.Windows.Forms.Button btnAltAluno;
        private System.Windows.Forms.Button btnVisAluno;
        private System.Windows.Forms.Button btnExcAluno;
    }
}

