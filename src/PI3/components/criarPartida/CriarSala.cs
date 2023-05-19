using PI3.components.navegacao;
using PI3.models;
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
        public string senhaSala { get; set; }
        public string nomePlayer { get; set; }


        public CriarSala()
        {
            InitializeComponent();
            ControlBox = false; //tira os negocios da janela do form
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Utils.isStringValid(txtNomeSala.Text) && Utils.isStringValid(txtSenhaSala.Text) && Utils.isStringValid(txtPlayerName.Text))
            {
                Program.partidaEstado = GameCore.criarPartida(txtNomeSala.Text, txtSenhaSala.Text);
                Program.partidaEstado.jogador = GameCore.entrarPartida(Program.partidaEstado.id, txtPlayerName.Text, txtSenhaSala.Text);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
