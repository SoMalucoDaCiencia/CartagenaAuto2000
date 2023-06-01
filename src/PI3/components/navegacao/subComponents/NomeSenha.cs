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

namespace PI3.components.navegacao
{
    public partial class NomeSenha : Form
    {

        public Partida partidaPretendida;
        public string nome { get; set; }
        public string senha { get; set; }

        public NomeSenha(Partida partida)
        {
            InitializeComponent();
            
            ControlBox = false; //tira os negocios da janela do form
            this.partidaPretendida = partida;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Utils.isStringValid(txtNome.Text) && Utils.isStringValid(txtSenha.Text)) {
                Player p = GameCore.entrarPartida(this.partidaPretendida.id, txtNome.Text, txtSenha.Text);
                Program.partidaEstado = Partida.EnterPartida(this.partidaPretendida.id, txtNome.Text, txtSenha.Text);
                Program.partidaEstado.jogador = p;
                GameCore.update(Program.partidaEstado);
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

        private void NomeSenha_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1000, 370);
        }
    }
}
