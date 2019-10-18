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
            this.btnPgto = new System.Windows.Forms.Button();
            this.btnFerias = new System.Windows.Forms.Button();
            this.btnIncAluno = new System.Windows.Forms.Button();
            this.btnAltAluno = new System.Windows.Forms.Button();
            this.btnVisAluno = new System.Windows.Forms.Button();
            this.btnExcAluno = new System.Windows.Forms.Button();
            this.alunoTableAdapter1 = new VirtualGym.VIRTUALGYMDataSet1TableAdapters.alunoTableAdapter();
            this.vIRTUALGYMDataSet11 = new VirtualGym.VIRTUALGYMDataSet1();
            this.virtualgymDataSet1 = new VirtualGym.VIRTUALGYMDataSet();
            this.alunoTableAdapter = new VirtualGym.VIRTUALGYMDataSetTableAdapters.alunoTableAdapter();
            this.vIRTUALGYMDataSet = new VirtualGym.VIRTUALGYMDataSet();
            this.dtGrdMat = new System.Windows.Forms.DataGridView();
            this.dtGrididAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vIRTUALGYMDataSet2 = new VirtualGym.VIRTUALGYMDataSet2();
            this.virtualgymDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter2 = new VirtualGym.VIRTUALGYMDataSet2TableAdapters.alunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualgymDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualgymDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPgto
            // 
            this.btnPgto.Location = new System.Drawing.Point(239, 507);
            this.btnPgto.Name = "btnPgto";
            this.btnPgto.Size = new System.Drawing.Size(203, 30);
            this.btnPgto.TabIndex = 1;
            this.btnPgto.Text = "Manutenção de Pagamento";
            this.btnPgto.UseVisualStyleBackColor = true;
            this.btnPgto.Click += new System.EventHandler(this.BtnPgto_Click);
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
            this.btnAltAluno.Click += new System.EventHandler(this.BtnAltAluno_Click_1);
            // 
            // btnVisAluno
            // 
            this.btnVisAluno.Location = new System.Drawing.Point(655, 89);
            this.btnVisAluno.Name = "btnVisAluno";
            this.btnVisAluno.Size = new System.Drawing.Size(123, 27);
            this.btnVisAluno.TabIndex = 5;
            this.btnVisAluno.Text = "Visualizar";
            this.btnVisAluno.UseVisualStyleBackColor = true;
            this.btnVisAluno.Click += new System.EventHandler(this.BtnVisAluno_Click);
            // 
            // btnExcAluno
            // 
            this.btnExcAluno.Location = new System.Drawing.Point(654, 122);
            this.btnExcAluno.Name = "btnExcAluno";
            this.btnExcAluno.Size = new System.Drawing.Size(123, 27);
            this.btnExcAluno.TabIndex = 6;
            this.btnExcAluno.Text = "Excluir";
            this.btnExcAluno.UseVisualStyleBackColor = true;
            this.btnExcAluno.Click += new System.EventHandler(this.BtnExcAluno_Click);
            // 
            // alunoTableAdapter1
            // 
            this.alunoTableAdapter1.ClearBeforeFill = true;
            // 
            // vIRTUALGYMDataSet11
            // 
            this.vIRTUALGYMDataSet11.DataSetName = "VIRTUALGYMDataSet1";
            this.vIRTUALGYMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virtualgymDataSet1
            // 
            this.virtualgymDataSet1.DataSetName = "VIRTUALGYMDataSet";
            this.virtualgymDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // vIRTUALGYMDataSet
            // 
            this.vIRTUALGYMDataSet.DataSetName = "VIRTUALGYMDataSet";
            this.vIRTUALGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtGrdMat
            // 
            this.dtGrdMat.AllowUserToAddRows = false;
            this.dtGrdMat.AllowUserToDeleteRows = false;
            this.dtGrdMat.AutoGenerateColumns = false;
            this.dtGrdMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtGrididAluno,
            this.dtGridNome});
            this.dtGrdMat.DataSource = this.alunoBindingSource1;
            this.dtGrdMat.Location = new System.Drawing.Point(36, 25);
            this.dtGrdMat.Name = "dtGrdMat";
            this.dtGrdMat.ReadOnly = true;
            this.dtGrdMat.RowHeadersVisible = false;
            this.dtGrdMat.Size = new System.Drawing.Size(542, 416);
            this.dtGrdMat.TabIndex = 7;
            // 
            // dtGrididAluno
            // 
            this.dtGrididAluno.DataPropertyName = "idAluno";
            this.dtGrididAluno.HeaderText = "Matrícula";
            this.dtGrididAluno.Name = "dtGrididAluno";
            this.dtGrididAluno.ReadOnly = true;
            // 
            // dtGridNome
            // 
            this.dtGridNome.DataPropertyName = "nome";
            this.dtGridNome.HeaderText = "Nome";
            this.dtGridNome.Name = "dtGridNome";
            this.dtGridNome.ReadOnly = true;
            this.dtGridNome.Width = 500;
            // 
            // alunoBindingSource1
            // 
            this.alunoBindingSource1.DataMember = "aluno";
            this.alunoBindingSource1.DataSource = this.vIRTUALGYMDataSet2;
            // 
            // vIRTUALGYMDataSet2
            // 
            this.vIRTUALGYMDataSet2.DataSetName = "VIRTUALGYMDataSet2";
            this.vIRTUALGYMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virtualgymDataSet1BindingSource
            // 
            this.virtualgymDataSet1BindingSource.DataSource = this.virtualgymDataSet1;
            this.virtualgymDataSet1BindingSource.Position = 0;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.virtualgymDataSet1BindingSource;
            // 
            // alunoTableAdapter2
            // 
            this.alunoTableAdapter2.ClearBeforeFill = true;
            // 
            // gerAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 589);
            this.Controls.Add(this.dtGrdMat);
            this.Controls.Add(this.btnExcAluno);
            this.Controls.Add(this.btnVisAluno);
            this.Controls.Add(this.btnAltAluno);
            this.Controls.Add(this.btnIncAluno);
            this.Controls.Add(this.btnFerias);
            this.Controls.Add(this.btnPgto);
            this.Name = "gerAluno";
            this.Text = "Gerenciamento de Alunos";
            this.Load += new System.EventHandler(this.GerAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualgymDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualgymDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPgto;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.Button btnIncAluno;
        private System.Windows.Forms.Button btnVisAluno;
        private System.Windows.Forms.Button btnExcAluno;
        private VIRTUALGYMDataSet1TableAdapters.alunoTableAdapter alunoTableAdapter1;
        private VIRTUALGYMDataSet1 vIRTUALGYMDataSet11;
        private VIRTUALGYMDataSet virtualgymDataSet1;
        private VIRTUALGYMDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private VIRTUALGYMDataSet vIRTUALGYMDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.BindingSource virtualgymDataSet1BindingSource;
        private VIRTUALGYMDataSet2 vIRTUALGYMDataSet2;
        private VIRTUALGYMDataSet2TableAdapters.alunoTableAdapter alunoTableAdapter2;
        public System.Windows.Forms.BindingSource alunoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtGrididAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtGridNome;
        public System.Windows.Forms.DataGridView dtGrdMat;
        public System.Windows.Forms.Button btnAltAluno;
    }
}

