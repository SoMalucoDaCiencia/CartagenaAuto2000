using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PI3.models;

namespace PI3.components.tabuleiro {

    public partial class TabuleiroForm : Form {

        int posicaoSelecionada = -1;

        Carta cartaSelecionada = null;

        bool lobbyView = true;

        List<Player> jogadores;

        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool stop = false;

        public TabuleiroForm() {
            // Init component
            InitializeComponent();

            // Hide defualt hidden components
            pnlChave.Hide();
            pnlEsqueleto.Hide();
            pnlFaca.Hide();
            pnlGarrafa.Hide();
            pnlPistola.Hide();
            pnlTricornio.Hide();

            // Init timer
            timerRoutine(null, null);
            timer.Interval = 5000;
            timer.Tick += timerRoutine;
            timer.Enabled = true;
        }

        private void timerRoutine(object Sender, EventArgs e) {
            dataGridView1.Visible = false;
            if (GameCore.update(Program.partidaEstado))
            {
                jogadores = GameCore.listarJogadores(Program.partidaEstado.id);
                this.lstPlayersLobby.Items.Clear();
                this.lstPlayersLobby.Items.AddRange(Player.GetPlayersNames(jogadores).ToArray());
                if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
                    lobbyView = false;
                } else {
                    lobbyView = true;
                }
                render();
                GC.Collect();
            }

        }

        public void tileClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            int prov = int.Parse(o.Tag.ToString().Split(',')[0].Split(':')[1]);
            var countPiratas = Program.partidaEstado.casas[prov];
            if (countPiratas.piratasPresentes.ContainsKey(Program.partidaEstado.jogador.id) && countPiratas.piratasPresentes[Program.partidaEstado.jogador.id] > 0) {
                this.posicaoSelecionada = prov;
                render();
            } else {
                MessageBox.Show("Você n tem piratas nessa casa");
            }
        }

        public void cardClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.cartaSelecionada = new Carta(o.Tag.ToString().Substring(0, 1));
            render();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            GameCore.jogar(Program.partidaEstado, posicaoSelecionada, cartaSelecionada);
            GameCore.update(Program.partidaEstado);
            render();
        }

        private void btnAuto_Click(object sender, EventArgs e) {
            Engine.process();
            GameCore.update(Program.partidaEstado);
            render();
        }

        private void checkButtons() {
            if (Program.partidaEstado.idJogadorAtual == Program.partidaEstado.jogador.id &&
                cartaSelecionada != null &&
                posicaoSelecionada > 0) {

            	this.btnEnter.Show();
            	this.btnAuto.Show();
            } else {
                this.btnEnter.Hide();
                this.btnAuto.Hide();
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e) {
            GameCore.iniciarPartida(Program.partidaEstado);
            Program.partidaEstado.state = PartidaState.PartidaEnum.INICIADA;
            if (GameCore.update(Program.partidaEstado) )
            {
            lobbyView = false;

            drawTabuleiro();
            pnlChave.Show();
            pnlEsqueleto.Show();
            pnlFaca.Show();
            pnlGarrafa.Show();
            pnlPistola.Show();
            pnlTricornio.Show();

            render();
            }

        }

        private void showQtd(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "G":
                    {
                        this.pnlGarrafa.BackgroundImage = null; break;
                    }
                case "T":
                    {// Tricornio
                        this.pnlTricornio.BackgroundImage = null; break;

                    }
                case "P":
                    {
                        this.pnlPistola.BackgroundImage = null; break;

                    }
                case "E":
                    {// Esqueleto(Jolly roger)
                        this.pnlEsqueleto.BackgroundImage = null; break;

                    }
                case "F":
                    {
                        this.pnlFaca.BackgroundImage = null; break;

                    }
                case "C":
                    {
                        this.pnlChave.BackgroundImage = null; break;

                    }
                default: break;
            }
        }

        private void setDefault(object sender, EventArgs e)
        {
            switch (((Button) sender).Tag)
            {
                case "G":
                    {
                        this.pnlGarrafa.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Garrafa, false); break;
                    }
                case "T":
                    {// Tricornio
                        this.pnlTricornio.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Tricornio, false); break;
                    }
                case "P":
                    {
                        this.pnlPistola.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Pistola, false); break;
                    }
                case "E":
                    {// Esqueleto(Jolly roger)
                        this.pnlEsqueleto.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Esqueleto, false); break;
                    }
                case "F":
                    {
                        this.pnlFaca.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Faca, false); break;
                    }
                case "C":
                    {
                        this.pnlChave.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Chave, false); break;
                    }
                default: break;
            }
        }


        // =========== Renderização =============>

        private void render() {
            checkButtons();
            drawLobby();
            if (lobbyView) {

                // Apaga todos os "Panel's" dos controls para liberar a memoria
                foreach (Control item in this.Controls.OfType<Panel>().ToList())
                {
                    this.Controls.Remove(item);
                }
                //drawCartas();
            }
        }

        private void drawLobby() {
            if (!lobbyView) {
                lstPlayersLobby.Hide();
                dataGridView1.Hide();
                btnIniciarPartida.Hide();
                btnAuto.Show();
                btnEnter.Show();
                btnHistorico.Show();
                //pnlChave.Show();
                //pnlEsqueleto.Show();
                //pnlFaca.Show();
                //pnlGarrafa.Show();
                //pnlPistola.Show();
                //pnlTricornio.Show();

            } else {
                lstPlayersLobby.Show();
                dataGridView1.Hide();
                btnIniciarPartida.Show();
                btnAuto.Hide();
                btnEnter.Hide();
                btnHistorico.Hide();
                //pnlChave.Hide();
                //pnlEsqueleto.Hide();
                //pnlFaca.Hide();
                //pnlGarrafa.Hide();
                //pnlPistola.Hide();
                //pnlTricornio.Hide();
            }
        }

        private void drawPiratas() {

            // Cria parametros de localizacao
            int marginLeft = 60;
            int marginTop = 55;
            int espY = 27;
            int espX = 42;
            int h = 65;
            int w = 65;

            // Cria um dicionario pra mapear referencia de cor pra cada jogador da partida
            Dictionary<int, Color.ColorEnum> peopleColor = new Dictionary<int, Color.ColorEnum>();
            peopleColor[Program.partidaEstado.jogador.id] = Color.ColorEnum.Azul;
            int c = 0;

            // Itera casas da partida
            Program.partidaEstado.casas.Keys.ToList().ForEach((key) => {
                int k = key - ((key / 6) * 6);
                int i = key / 6;
                int piratas = 1;

                // Pega casa e itera piratas de jogadores naquela casa
                Program.partidaEstado.casas[key].piratasPresentes.Keys.ToList().ForEach((innerKey) => {
                    if (innerKey > 0 && innerKey < 37) {
                        // Se o jogador nunca foi citado, associa ele uma nova cor
                        if (!peopleColor.ContainsKey(innerKey)) {
                            peopleColor[innerKey] = (Color.ColorEnum)c;
                            c++;
                        }

                        // Itera piratas de um jogador especifico
                        for (int d = 0; d < Program.partidaEstado.casas[key].piratasPresentes[innerKey]; d++) {
                            // Cria desenho do pirata
                            Panel p = new Panel();
                            p.BackgroundImage = Color.getPirate(peopleColor[innerKey]);
                            p.BackColor = System.Drawing.Color.Transparent;
                            p.BackgroundImageLayout = ImageLayout.Stretch;
                            p.Height = 10;
                            p.Width = 10;

                            int top = (piratas == 1 ? (w / 2) : (w / 4));
                            int left = (piratas == 1 ? (w / 4) : (piratas == 2 ? (w / 2) : (w * (3 / 4))));

                            p.Top = top + marginTop + espY + (h + espY) * (i%2==0 ? k : 5-k);
                            p.Left = left + marginLeft + espX + (h + espX) * i;

                            this.Controls.Add(p);
                            piratas++;
                        }
                    }
                });
            });
        }

        private void drawTabuleiro() {
            // Cria parametros de localizacao
            int marginLeft = 60;
            int marginTop = 55;
            int espY = 27;
            int espX = 42;
            int h = 65;
            int w = 65;

            // Itera casas da partida
            Program.partidaEstado.casas.Keys.ToList().ForEach((key) => {
                int k = key - ((key / 6) * 6);
                int i = key / 6;
                int piratas = 1;

                Panel tile = new Panel();
                tile.BackgroundImage = Carta.GetCardBitmap(Program.partidaEstado.casas[(6 * i) + k].tipoPosicao, true);
                tile.BackgroundImageLayout = ImageLayout.Stretch;
                tile.BackColor = System.Drawing.Color.Transparent;
                tile.Top = marginTop + espY + (h + espY) * (i % 2 == 0 ? k : 5 - k);
                tile.Left = marginLeft + espX + (h + espX) * i;
                tile.Width = w;
                tile.Height = h;

                tile.Tag = "i:" + ((6 * i) + k);
                tile.Click += tileClick;
                this.Controls.Add(tile);     
            });
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
        }
    }
}










