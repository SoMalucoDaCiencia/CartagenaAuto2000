using PI3.components.criarPartida;
using PI3.components.navegacao;
using PI3.components.tabuleiro;
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
            this.lstListarPartidas.SelectionChanged += new System.EventHandler(this.lstListarPartidas_SelectedIndexChanged);
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
            this.lstListarPartidas.Rows.Clear();
            partidas.ForEach((partida) => {
                this.lstListarPartidas.Rows.Add(partida.id.ToString(), partida.name.ToString(), partida.createdAt.ToString().Substring(0, 10));
            });
        }

        private void enableGrid(object sender, EventArgs e)
        {
            lstListarPartidas.Tag = "";
        }

        private void lstListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(partidas.Count > 0 && lstListarPartidas.Tag != "not")
            {
                int i = int.Parse(lstListarPartidas.CurrentRow.Index.ToString());
                partidaSelecionada = partidas[i == -1 ? 0 : i] ;

                NomeSenha criarSala = new NomeSenha(partidaSelecionada.id);
                var result = criarSala.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TabuleiroForm tab = new TabuleiroForm();
                    tab.Show();
                    criarSala.Close();
                    this.Hide();
                }
            }
            
        }
    }
}
