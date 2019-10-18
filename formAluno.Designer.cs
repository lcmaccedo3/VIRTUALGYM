namespace VirtualGym
{
    partial class formAluno
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
            this.components = new System.ComponentModel.Container();
            this.btnBiometria = new System.Windows.Forms.Button();
            this.btnGrv = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.ComboBox();
            this.dtMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vIRTUALGYMDataSet = new VirtualGym.VIRTUALGYMDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new VirtualGym.VIRTUALGYMDataSetTableAdapters.alunoTableAdapter();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBiometria
            // 
            this.btnBiometria.Location = new System.Drawing.Point(12, 378);
            this.btnBiometria.Name = "btnBiometria";
            this.btnBiometria.Size = new System.Drawing.Size(121, 23);
            this.btnBiometria.TabIndex = 0;
            this.btnBiometria.Text = "Biometria";
            this.btnBiometria.UseVisualStyleBackColor = true;
            this.btnBiometria.Click += new System.EventHandler(this.BtnBiometria_Click);
            // 
            // btnGrv
            // 
            this.btnGrv.Location = new System.Drawing.Point(511, 378);
            this.btnGrv.Name = "btnGrv";
            this.btnGrv.Size = new System.Drawing.Size(131, 23);
            this.btnGrv.TabIndex = 1;
            this.btnGrv.Text = "Salvar";
            this.btnGrv.UseVisualStyleBackColor = true;
            this.btnGrv.Click += new System.EventHandler(this.BtnGrv_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(648, 378);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(120, 23);
            this.btnCanc.TabIndex = 2;
            this.btnCanc.Text = "Sair";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.BtnCanc_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(644, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 87);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(219, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(258, 87);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(231, 20);
            this.txtRG.TabIndex = 6;
            // 
            // cmbUF
            // 
            this.cmbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUF.Location = new System.Drawing.Point(12, 141);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(121, 21);
            this.cmbUF.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(153, 142);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(615, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(12, 194);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(145, 20);
            this.txtCEP.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(209, 194);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(559, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 251);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(756, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // txtPlano
            // 
            this.txtPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPlano.FormattingEnabled = true;
            this.txtPlano.Items.AddRange(new object[] {
            "1 - Mensal",
            "2 - Anual"});
            this.txtPlano.Location = new System.Drawing.Point(12, 305);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(121, 21);
            this.txtPlano.TabIndex = 12;
            // 
            // dtMatricula
            // 
            this.dtMatricula.Location = new System.Drawing.Point(153, 306);
            this.dtMatricula.Name = "dtMatricula";
            this.dtMatricula.Size = new System.Drawing.Size(222, 20);
            this.dtMatricula.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Data da Matrícula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Plano";
            // 
            // vIRTUALGYMDataSet
            // 
            this.vIRTUALGYMDataSet.DataSetName = "VIRTUALGYMDataSet";
            this.vIRTUALGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.vIRTUALGYMDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // mskID
            // 
            this.mskID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskID.Location = new System.Drawing.Point(13, 35);
            this.mskID.Mask = "00000";
            this.mskID.Name = "mskID";
            this.mskID.ReadOnly = true;
            this.mskID.Size = new System.Drawing.Size(100, 20);
            this.mskID.TabIndex = 25;
            this.mskID.ValidatingType = typeof(int);
            // 
            // formAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtMatricula);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.cmbUF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnGrv);
            this.Controls.Add(this.btnBiometria);
            this.Name = "formAluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vIRTUALGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private VIRTUALGYMDataSet vIRTUALGYMDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private VIRTUALGYMDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        public System.Windows.Forms.MaskedTextBox mskID;
        public System.Windows.Forms.Button btnBiometria;
        public System.Windows.Forms.Button btnGrv;
        public System.Windows.Forms.Button btnCanc;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCPF;
        public System.Windows.Forms.TextBox txtRG;
        public System.Windows.Forms.ComboBox cmbUF;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtCEP;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.ComboBox txtPlano;
        public System.Windows.Forms.DateTimePicker dtMatricula;
    }
}