using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualGym
{
    public partial class formAluno : Form
    {
        public formAluno()
        {
            InitializeComponent();
        }
        public bool inserir;
        public void BtnGrv_Click(object sender, EventArgs e)
        {
            DateTime dataatual = Convert.ToDateTime(dtMatricula.Text);
            string competencia = dataatual.Year.ToString() + dataatual.Month.ToString();

            if (inserir)
            {

                string cPlano = this.txtPlano.SelectedItem.ToString().Substring(0, 1);
                StringBuilder cQuery = new StringBuilder();
                cQuery.Append("INSERT INTO [dbo].[aluno] ([idAluno],[nome],[cpf],[rg],[uf],[cidade],[cep],[bairro],[endereco],[tipoplano],[datamat],[biometria])"
                            + "VALUES ('" + Convert.ToInt32(mskID.Text) + "', '" + txtNome.Text + "', '" + txtCPF.Text + "', '" + txtRG.Text + "', '"
                            + cmbUF.Text + "', '" + txtCidade.Text + "', '" + txtCEP.Text + "', '" + txtBairro.Text + "','"
                            + txtEndereco.Text + "','" + cPlano + "', '" + Convert.ToDateTime(dtMatricula.Text) + "','')"
                            
                            + "INSERT INTO[dbo].[pagamento]([idCompetencia],[vencimento],[pagamento],[situacao],[idAluno])"
                            + "VALUES('" + competencia + "','" + Convert.ToDateTime(dtMatricula.Text) + "','','1','" + Convert.ToInt32(mskID.Text) + "')");
                            
                //+txtEndereco.Text + "', '" + txtPlano.Items + "', '" + Convert.ToDateTime(dtMatricula.Text) + "','')");
                Database.engineDb conn1 = new Database.engineDb();
                DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
                MessageBox.Show("Aluno matriculado com sucesso!");
                this.txtNome.Clear();
                this.txtCPF.Clear();
                this.txtRG.Clear();
                this.txtCidade.Clear();
                this.txtCEP.Clear();
                this.txtBairro.Clear();
                this.txtEndereco.Clear();
                this.Close();

            }

            else
            {
                StringBuilder cQuery = new StringBuilder();               
                cQuery.Append(" UPDATE aluno SET nome = '" + txtNome.Text + "', cpf = '" + txtCPF.Text + "', rg = '" + txtRG.Text + "', uf = '"
                            + cmbUF.Text + "', cidade = '" + txtCidade.Text + "', cep = '" + txtCEP.Text + "', bairro = '" + txtBairro.Text + "', endereco ='"
                            + txtEndereco.Text + "' FROM aluno WHERE idAluno =" + Convert.ToInt32(mskID.Text) );
                Database.engineDb conn = new Database.engineDb();
                DataSet ds1 = conn.RetornaDataSet(cQuery.ToString());
                MessageBox.Show("Aluno alterado com sucesso!");
                this.txtNome.Clear();
                this.txtCPF.Clear();
                this.txtRG.Clear();
                this.txtCidade.Clear();
                this.txtCEP.Clear();
                this.txtBairro.Clear();
                this.txtEndereco.Clear();
                this.Close();
                gerAluno.ActiveForm.Refresh();
            }


        }
        public void FormAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vIRTUALGYMDataSet.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.vIRTUALGYMDataSet.aluno);

        }


        private void BtnCanc_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBiometria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade não Implementada!");
            Close();
        }
    }
}
