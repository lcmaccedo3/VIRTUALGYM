namespace VirtualGym
{
    partial class formManutPgto
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnEstorno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridPgto = new System.Windows.Forms.DataGridView();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPgto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(118, 25);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(490, 20);
            this.txtNomeAluno.TabIndex = 0;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(22, 68);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(586, 20);
            this.txtPlano.TabIndex = 1;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(695, 23);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 23);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // btnEstorno
            // 
            this.btnEstorno.Location = new System.Drawing.Point(695, 68);
            this.btnEstorno.Name = "btnEstorno";
            this.btnEstorno.Size = new System.Drawing.Size(75, 23);
            this.btnEstorno.TabIndex = 3;
            this.btnEstorno.Text = "Estornar";
            this.btnEstorno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plano";
            // 
            // dtGridPgto
            // 
            this.dtGridPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPgto.Location = new System.Drawing.Point(22, 107);
            this.dtGridPgto.Name = "dtGridPgto";
            this.dtGridPgto.Size = new System.Drawing.Size(586, 313);
            this.dtGridPgto.TabIndex = 6;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(22, 25);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(90, 20);
            this.txtMat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matrícula";
            // 
            // formManutPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.dtGridPgto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstorno);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.txtNomeAluno);
            this.Name = "formManutPgto";
            this.Text = "Manutenção de Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnBaixar;
        public System.Windows.Forms.Button btnEstorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dtGridPgto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMat;
        public System.Windows.Forms.TextBox txtNomeAluno;
        public System.Windows.Forms.TextBox txtPlano;
    }
}