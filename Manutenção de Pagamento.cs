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
    public partial class formManutPgto : Form
    {
        public formManutPgto()
        {
            InitializeComponent();
        }

        public void popularGrid(string consulta)
        {
            StringBuilder consulta1 = new StringBuilder();
            consulta1.Append(consulta);
            dtGridPgto.DataSource = consulta1;
        }
        private void FormManutPgto_Load(object sender, EventArgs e)
        {

        }

    
    }
}
