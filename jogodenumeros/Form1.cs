using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogodeNumeros : Form
    {
        int randomNumber;
        int numeroTantativas = 10;
        int palpitedoJogador;
        bool JogoGanho = false;
        string dica;

        public frmJogodeNumeros()
        {
            InitializeComponent();
        }

        private void FrmJogodeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void btnTentativas_Click_1(object sender, EventArgs e)
        {
            //Verifica se o número de tentativas chegou a 0
            if(numeroTantativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou!";
                return;
            }

            //Validação do valor do palpite (entre 1 e 100)
            if (!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100)
            {
                txtNumeroInserido.Text = "Por favor, insira um número entre 1 e 100.";
                return;
            }
            numeroTantativas--;
            lblNumeroTentativas.Text = numeroTantativas.ToString();


            if (palpitedoJogador == randomNumber)
            {
                JogoGanho = true;
                dica = "Parabéns, você acertou!";
            }
            else if (palpitedoJogador < randomNumber)
            {
                dica = "O número do seu palpite é menor";
            }
            else
            {
                dica = "O número do seu palpite é maior";
            }

            txtResultado.Text = dica;
        }
    }
}
