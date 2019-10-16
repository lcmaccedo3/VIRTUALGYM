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

        private void BtnGrv_Click(object sender, EventArgs e)
        {
            /*
            mskID.Text;
            txtNome.Text;
            txtCPF.Text;
            txtRG.Text;
            cmbUF.Text;
            txtCidade.Text;
            txtCEP.Text;
            txtBairro.Text;
            txtEndereco.Text;
            dtMatricula.Text;
            txtPlano.Text;
            */
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'vIRTUALGYMDataSet.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.vIRTUALGYMDataSet.aluno);

        }
    }
}
