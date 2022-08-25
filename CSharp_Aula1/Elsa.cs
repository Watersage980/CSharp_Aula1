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
    public partial class Elsa : Form
    {
        public Elsa()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Jafar form=new Jafar();
            form.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Simba form=new Simba();
            form.Show();
        }
    }
}
