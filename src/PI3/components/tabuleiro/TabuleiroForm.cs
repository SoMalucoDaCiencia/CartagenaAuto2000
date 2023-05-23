using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;
using PI3.models;

namespace PI3.components.tabuleiro {

    public partial class TabuleiroForm : Form {

        int posicaoSelecionada = -1;

        Carta cartaSelecionada = null;

        bool initModalView = true;

        List<Player> jogadores;

        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool stop = false;

        public TabuleiroForm() {
            InitializeComponent();
            ControlBox = false;
            InitializeTimer();
        }

        private void InitializeTimer()
        { 
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
 
            timer.Enabled = true;
        }

        private void timer_Tick(object Sender, EventArgs e)
        { 
            GameCore.update(Program.partidaEstado);
            if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA)
            {
                initModalView = false;
                this.updateLobby();
                render();
            }
            else
            {
                initModalView = true;
                jogadores = GameCore.listarJogadores(Program.partidaEstado.id);
                lstListarPlayers.Items.Clear();
                lstListarPlayers.Items.AddRange(Player.GetPlayersNames(jogadores).ToArray());
                this.updateLobby();
            }
        } 

        private void updateLobby()
        {
            if (!initModalView)
            {
                lstListarPlayers.Hide();
                dataGridView1.Show();
                btnIniciarPartida.Hide();
                btnAuto.Show();
                btnEnter.Show();
            } else {
                lstListarPlayers.Show();
                dataGridView1.Hide();
                btnIniciarPartida.Show();
                btnAuto.Hide();
                btnEnter.Hide();
            }
        }

        private void render() {
            if (!initModalView)
            {
            setTabuleiro();
            setCartas();
            checkButtons();
            }
        }

        private void setTabuleiro() {
            for (int i = 0; i < 6; i++) {
                for (int k = 0; k < 6; k++) {
                    Panel p = new Panel();
                    int marginTop = 0;
                    int marginLeft = 0;
                    int h = 55; //ç
                    int w = 55;
                    int esp = 70;
                    p.BackgroundImage = Carta.GetCardBitmap(Program.partidaEstado.casas[(6 * i) + k].tipoPosicao, true);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Top = marginTop + esp + (h + esp) * ((i % 2 == 0 ? 0 : 5) + (k * (i % 2 == 0 ? 1 : -1)));
                    p.Left = marginLeft + esp + (h + esp) * i;
                    p.Width = w;
                    p.Height = h;

                    p.Tag = "i:" + ((6 * i) + k);
                        //          + ",x1:" + (p.Left + (w/4)) +
                        // ",x2:" + (p.Left + (w/2)) +
                        // ",x3:" + (p.Left + (w*3/4)) +
                        // ",y1:" + (p.Top -  (w*3/4)) +
                        // ",y2:" + (p.Top - (w/4)) +
                        // ",y3:" + (p.Top - (w*3/4));

                    p.Click += tileClick;
                    this.Controls.Add(p);
                }
            }
        }

        private void setCartas() {
            var i = 0;
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                i++;
                Panel p = new Panel();
                int h = 60;
                int w = 60;
                int esp = 15;
                p.BackgroundImage = Carta.GetCardBitmap(carta.tipo, false);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Top = esp + (i > 2 ? (esp + h) : 0);
                p.Left = esp + ((i % 3) * w);
                p.Width = w;
                p.Height = h;

                p.Tag = carta.ToString();
            });
        }

        private void setPirates() {
            if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
                for (int i=0; i<36; i++) {
                    int count = 0;
                    Program.partidaEstado.casas[i].piratasPresentes.Keys.ToList().ForEach((key) => {
                        count++;
                        for (int r = 0; r < Program.partidaEstado.casas[i].piratasPresentes[key]; r++) {

                        }
                    });
                }
            }
        }

        public void tileClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            int prov = int.Parse(o.Tag.ToString().Split(',')[0].Split(':')[1]);
            if (Program.partidaEstado.casas[prov].piratasPresentes[Program.partidaEstado.jogador.id] > 0) {
                this.posicaoSelecionada = prov;
                render();
                checkButtons();
            } else {
                MessageBox.Show("Você n tem piratas nessa casa");
            }
        }

        public void cardClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.cartaSelecionada = new Carta(o.Tag.ToString().Substring(0, 1));
            checkButtons();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            GameCore.jogar(Program.partidaEstado, posicaoSelecionada, cartaSelecionada);
        }

        private void btnAuto_Click(object sender, EventArgs e) {
            Engine.process();
        }

        private void checkButtons() {
            if (Program.partidaEstado.idJogadorAtual == Program.partidaEstado.jogador.id &&
                cartaSelecionada != null &&
                posicaoSelecionada > 0) {

            	this.btnEnter.Enabled = true;
            	this.btnAuto.Enabled = true;
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            GameCore.iniciarPartida(Program.partidaEstado);
            Program.partidaEstado.state = PartidaState.PartidaEnum.INICIADA;
            updateLobby();
            GameCore.update(Program.partidaEstado);
            render();
            initModalView = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}










