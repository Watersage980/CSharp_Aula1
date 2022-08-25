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
    public partial class Jafar : Form
    {
        public Jafar()
        {
            InitializeComponent();
        }
        string nome;
        string sobrenome;
        int N1;
        int N2;
        int N3;
        int i;

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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void btnValorizar_Click(object sender, EventArgs e)
        {
            i= int.Parse(txtContagem.Text);
            if (i != 0)
            {
                N3 = N3 + int.Parse(txtValor.Text);
                txtTotal.Text = N3.ToString();
                txtValor.Text = "";
                i = i - 1 ;
                if (i == 0)
                {
                    btnValorizar.Visible = false;
                }
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            Simba form = new Simba();
            form.Show();
        }
    }
}
