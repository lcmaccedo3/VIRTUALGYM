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
        public gerAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vIRTUALGYMDataSet.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.vIRTUALGYMDataSet.aluno);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        public void BtnIncAluno_Click(object sender, EventArgs e)
        {
            formAluno formAlunoInc = new formAluno();
            formAlunoInc.ShowDialog();
            StringBuilder cQuery = new StringBuilder();
            cQuery.Append("SELECT MAX(idAluno) + 1 FROM aluno");
            Database.engineDb conn1 = new Database.engineDb();
            DataSet ds = conn1.RetornaDataSet(cQuery.ToString());
            formAluno.mskID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

        }
    }
}
