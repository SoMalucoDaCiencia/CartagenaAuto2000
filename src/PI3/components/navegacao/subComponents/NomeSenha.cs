using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.components.navegacao
{
    public partial class NomeSenha : Form
    {

        public int idPretendido;
        public string nome { get; set; }
        public string senha { get; set; }

        public NomeSenha(int idPartida)
        {
            InitializeComponent();
            
            ControlBox = false; //tira os negocios da janela do form
            this.idPretendido = idPartida;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Utils.isStringValid(txtNome.Text) && Utils.isStringValid(txtSenha.Text)) {
                Program.partidaEstado.jogador = GameCore.entrarPartida(this.idPretendido, txtNome.Text, txtSenha.Text);
                this.Close();
            } else {
                MessageBox.Show("Nomes e senha não podem ser nulos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
