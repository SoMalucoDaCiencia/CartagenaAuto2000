using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.components.criarPartida
{
    public partial class CriarSala : Form
    {
        public string nomeSala { get; set; }
        public string nomeJogador { get; set; }
        public string senhaSala { get; set; }

        public CriarSala()
        {
            InitializeComponent();
            ControlBox = false; //tira os negocios da janela do form
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Utils.isStringValid(txtNomeSala.Text) && Utils.isStringValid(txtSenhaSala.Text) && Utils.isStringValid(txtNomeJogador.Text))
            {
                nomeSala = txtNomeSala.Text;
                senhaSala = txtSenhaSala.Text;
                nomeJogador = txtNomeJogador.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nomes e senha não podem ser nulos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
