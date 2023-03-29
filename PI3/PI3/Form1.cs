using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace PI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int idPartida;

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T"); 
            retorno = retorno.Replace("\r", ""); 
            string[] partidas = retorno.Split('\n'); 

            for (int i = 0; i < partidas.Length; i++)
            {
                lstListaDePartidas.Items.Add(partidas[i]);
            }
        }

        private void btnPartidaSelecionada_Click(object sender, EventArgs e)
        {
            string partida = lstListaDePartidas.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string status = itens[3];

            lblPartidaSelecionada.Text = "Id: " + idPartida.ToString() + "\nNome: " + nomePartida;
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomeP = txtNomePartida.Text;
            string senhaP = txtCriarSenha.Text;
            string retorno = Jogo.CriarPartida(nomeP, senhaP);
            lblCriarPartida.Text = "Id partida: " + retorno;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJogador.Text;
            string senha = txtSenhaPartida.Text;

            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);
            retorno = retorno.Replace("\r", "");
            string[] retornoP = retorno.Split(',');

            string jogadores = Jogo.ListarJogadores(idPartida);
            jogadores = jogadores.Replace("\r", "");
            string[] jogador = jogadores.Split('\n');

            for (int i = 0; i < jogador.Length; i++)
            {
                lstListaDeJogadores.Items.Add(jogador[i]);
            }

            if (retorno.StartsWith("ERRO"))
                MessageBox.Show(retorno, "PI Cartagena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < retornoP.Length; i++)
                {
                    lstDadosPartidaEntrada.Items.Add(retornoP[i]);
                }
            }
                
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string jogadores = Jogo.ListarJogadores(idPartida);
            jogadores = jogadores.Replace("\r", "");
            string[] jogador = jogadores.Split('\n');

            for (int i = 0; i < jogador.Length; i++)
            {
                lstListaDeJogadores.Items.Add(jogador[i]);
            }
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            string mapa = Jogo.ExibirTabuleiro(idPartida);
            mapa = mapa.Replace("\r", "");
            string[] tabuleiro = mapa.Split('\n');

            for (int i = 0; i < tabuleiro.Length; i++)
            {
                lstTabuleiro.Items.Add(tabuleiro[i]);
            }

            Console.WriteLine(Jogo.ExibirTabuleiro(idPartida));
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string iniciar = Jogo.IniciarPartida(362, "55EA81");
            Console.WriteLine(iniciar);
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            //string mao = Jogo.ConsultarMao(362, "55EA81");
            string mao = Jogo.ConsultarMao(363, "1F8DAE");
            mao = mao.Replace("\r", "");
            string[] exibirM = mao.Split('\n');

            for (int i = 0; i < exibirM.Length; i++)
            {
                lstExibirMao.Items.Add(exibirM[i]);
            }
        }

        private void btnJogarFrente_Click(object sender, EventArgs e)
        {
            //string jogar = Jogo.Jogar(362, "55EA81", 0, "G");
            string jogar = Jogo.Jogar(363, "1F8DAE", 0, "T");
            Console.WriteLine(jogar);
        }

        private void btnJogarTras_Click(object sender, EventArgs e)
        {
            string jogarTras = Jogo.Jogar(362, "55EA81", 5);
            Console.WriteLine(jogarTras);
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            //string pularVez = Jogo.Jogar(362, "55EA81");
            string pularVez = Jogo.Jogar(363, "1F8DAE");
            Console.WriteLine(pularVez);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            string historico = Jogo.ExibirHistorico(idPartida);
            historico = historico.Replace("\r", "");
            string[] hist = historico.Split('\n');

            for(int i = 0; i < hist.Length; i++)
            {
                lstHistorico.Items.Add(hist[i]);
            }
        }


    }
}
