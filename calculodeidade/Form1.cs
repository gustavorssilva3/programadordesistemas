using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodeidade
{
    public partial class frmCalculoIdade : Form
    {
        public frmCalculoIdade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anonacimento, anoatual, idade;

            anonacimento = int.Parse(txtAnoNasc.Text);

            anoatual = int.Parse(txtAnoAtual.Text);

            idade = anoatual - anonacimento;

            lblIdade.Text = idade.ToString();



        }
    }
}
