using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e) //função do evento de click do botão 'Clique Aqui'
        {
            int v1 = Convert.ToInt32(txtValor1.Text); //armazena o valor1 que vai ser inserido na caixa de texto e converte para int 32bits
            int v2 = Convert.ToInt32(txtValor2.Text); //faz o mesmo do v1, só q com o valor2

            int soma = v1 + v2; //soma os dois valores

            lblResultado.Text = soma.ToString(); //converte o valor de 'soma' para string, armazena na label e muda o texto dela 
        }
    }
}
