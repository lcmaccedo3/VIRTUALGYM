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
    public partial class gerAluno : Form

    {
        public bool inserir;
        public gerAluno()
        {
            InitializeComponent();
        }


        private void BtnIncAluno_Click(object sender, EventArgs e)
        {

            formAluno formAlunoInc = new formAluno();
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT MAX(idAluno) + 1 as ID FROM aluno");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            formAlunoInc.mskID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            formAlunoInc.txtNome.Clear();
            formAlunoInc.txtCPF.Clear();
            formAlunoInc.txtRG.Clear();
            //formAlunoInc.cmbUF.Items();
            formAlunoInc.txtCidade.Clear();
            formAlunoInc.txtCEP.Clear();
            formAlunoInc.txtBairro.Clear();
            formAlunoInc.txtEndereco.Clear();
            //formAlunoInc.dtMatricula
            //formAlunoInc.txtPlano.Clear();
            formAlunoInc.inserir = true;
            formAlunoInc.ShowDialog();

        }

        private void BtnAltAluno_Click(object sender, EventArgs e)
        {
        }

        private void BtnExcAluno_Click(object sender, EventArgs e)
        {
            var matsel = this.dtGrdMat.CurrentRow.Cells[0].Value.ToString();
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT MAX(situacao) FROM pagamento WHERE idAluno = '" + matsel + "' ");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            var verifpgto = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            if (Convert.ToInt32(verifpgto) == 1)
            {
                StringBuilder cQuery1 = new StringBuilder();
                cQuery1.Append("DELETE FROM pagamento WHERE idAluno = '" + matsel + "' " +
                    "DELETE FROM aluno WHERE idAluno = '" + matsel + "'"+
                    "DELETE FROM ferias WHERE idAluno = '" + matsel + "'");
                Database.engineDb conn2 = new Database.engineDb();
                DataSet ds1 = conn1.RetornaDataSet(cQuery1.ToString());
                MessageBox.Show("Aluno excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Não será possível excluir o aluno pois possui título baixado!");
            }


        }


        private void GerAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vIRTUALGYMDataSet2.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter2.Fill(this.vIRTUALGYMDataSet2.aluno);
            // TODO: esta linha de código carrega dados na tabela 'vIRTUALGYMDataSet11.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter1.Fill(this.vIRTUALGYMDataSet11.aluno);

        }


        private void BtnAltAluno_Click_1(object sender, EventArgs e)
        {
            var matsel = this.dtGrdMat.CurrentRow.Cells[0].Value.ToString();
            formAluno formAlunoAlt = new formAluno();
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT *, Convert(datetime,datamat) AS DATAMAT, Case WHEN tipoplano = '1' THEN '1 - Mensal' Else '2 - Anual' END AS PLANO FROM aluno WHERE idAluno = '" + matsel+"' ");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            formAlunoAlt.mskID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            formAlunoAlt.txtNome.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            formAlunoAlt.txtCPF.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            formAlunoAlt.txtRG.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            formAlunoAlt.cmbUF.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            formAlunoAlt.txtCidade.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            formAlunoAlt.txtCEP.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            formAlunoAlt.txtBairro.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            formAlunoAlt.txtEndereco.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            formAlunoAlt.dtMatricula.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString() ;
            formAlunoAlt.txtPlano.Text = ds.Tables[0].Rows[0].ItemArray[13].ToString();
            formAlunoAlt.dtMatricula.Enabled = false;
            formAlunoAlt.txtPlano.Enabled = false;
            formAlunoAlt.ShowDialog();
        }

        private void BtnVisAluno_Click(object sender, EventArgs e)
        {
            var matsel = this.dtGrdMat.CurrentRow.Cells[0].Value.ToString();
            formAluno formAlunoVis = new formAluno();
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT *, Convert(datetime,datamat) AS DATAMAT, Case WHEN tipoplano = '1' THEN '1 - Mensal' Else '2 - Anual' END AS PLANO FROM aluno WHERE idAluno = '" + matsel + "' ");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            formAlunoVis.mskID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            formAlunoVis.txtNome.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            formAlunoVis.txtCPF.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            formAlunoVis.txtRG.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            formAlunoVis.cmbUF.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            formAlunoVis.txtCidade.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            formAlunoVis.txtCEP.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            formAlunoVis.txtBairro.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            formAlunoVis.txtEndereco.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            formAlunoVis.dtMatricula.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            formAlunoVis.txtPlano.Text = ds.Tables[0].Rows[0].ItemArray[13].ToString();
            formAlunoVis.dtMatricula.Enabled = false;
            formAlunoVis.txtPlano.Enabled = false;
            formAlunoVis.btnGrv.Enabled = false;
            formAlunoVis.ShowDialog();
        }

        private void BtnPgto_Click(object sender, EventArgs e)
        {
            var matsel = this.dtGrdMat.CurrentRow.Cells[0].Value.ToString();
            formManutPgto formManutPgto = new formManutPgto();            
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT aluno.idAluno,aluno.nome,pagamento.idCompetencia, pagamento.vencimento, pagamento.pagamento, "
                                + "Case WHEN aluno.tipoplano = '1' THEN '1 - Mensal' Else '2 - Anual' END AS PLANO,"
                                + "Case WHEN pagamento.situacao = '1' THEN 'Regular'"
                                + "     WHEN DATEDIFF(DAY, CONVERT(DATE, pagamento.vencimento), pagamento.pagamento) < 0 AND pagamento.situacao = '1'  THEN 'Vencido' "
                                + "     WHEN pagamento.situacao = '1' THEN 'Pago' END AS Situação "
                                + "FROM pagamento INNER JOIN aluno on "
                                + "pagamento.idAluno = aluno.idAluno "
                                + "WHERE pagamento.idAluno ='" + matsel + "'");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            formManutPgto.popularGrid(cQuery.ToString());
            formManutPgto.txtMat.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            formManutPgto.txtNomeAluno.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString(); 
            formManutPgto.txtPlano.Text= ds.Tables[0].Rows[0].ItemArray[5].ToString(); 
            formManutPgto.ShowDialog();
        }
    }
}
