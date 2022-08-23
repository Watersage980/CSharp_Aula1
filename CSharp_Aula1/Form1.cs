using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome;
        string sobrenome;
        int N1;
        int N2;

        private void btnUniao_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            nome = nome + " " + sobrenome;

            txtNomeCompleto.Text = nome;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            N1 = int.Parse(txtN1.Text);
            N2 = int.Parse(txtN2.Text);
            N1 = N1 + N2;
            if (N1>=10)
            {
                if (N1>10)
                {
                    txtN3.Text = "A soma é " + N1.ToString() + " e é maior que 10";
                }
                else
                {
                    txtN3.Text = "A soma é 10";
                }
            }
            else
            {
                txtN3.Text = "A soma é " + N1.ToString() + " e é menor que 10";
            }
        }
    }
}
