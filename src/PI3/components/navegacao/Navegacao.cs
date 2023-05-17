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

namespace PI3
{
    public partial class Navegacao : Form
    {
        public Partida partidaSelecionada;
        List<Partida> partidas;

        public Navegacao()
        {
            InitializeComponent();
            ControlBox = false; //tira os negocios da janela do form
            updateList();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            partidas = GameCore.listarPartidas(PartidaState.PartidaEnum.ABERTA);
            lstListarPartidas.Items.Clear();
            lstListarPartidas.Items.AddRange(Partida.getPartidasNames(partidas).ToArray());
        }

        private void lstListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(partidas.Count > 0)
            {
                partidaSelecionada = partidas[lstListarPartidas.SelectedIndex == -1 ? 0 : lstListarPartidas.SelectedIndex];
                NomeSenha nomeSenha = new NomeSenha();
                var result = nomeSenha.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Player player = GameCore.entrarPartida(partidaSelecionada.id, nomeSenha.nome, nomeSenha.senha);
                    if (player != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Senha errada, tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
