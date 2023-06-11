using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CartagenaServer;
using PI3.models;
using System.Windows.Forms;

namespace PI3.components.tabuleiro{
    public partial class TabuleiroForm : Form{
        bool lobbyView = true;

        List<Player> jogadores;

        static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool stop = false;

        public TabuleiroForm() {
            // Init component
            InitializeComponent();

            // Hide defualt hidden components
            showLobby();

            // Init timer
            timerRoutine(null, null);
            timer.Interval = 5000;
            timer.Tick += timerRoutine;
            timer.Enabled = true;
        }

        private void timerRoutine(object Sender, EventArgs e) {
            GameCore.update(Program.partidaEstado);

            if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
                checkButtons();
                updateMao();
                listarHistorico();
            } else {
                jogadores = GameCore.listarJogadores(Program.partidaEstado.id);
                this.lstPlayersLobby.Items.Clear();
                this.lstPlayersLobby.Items.AddRange(Player.GetPlayersNames(jogadores).ToArray());
            }
        }

        public void updateMao() {
            lblFaca.Text = "0";
            lblChave.Text = "0";
            lblTricornio.Text = "0";
            lblEsqueleto.Text = "0";
            lblGarrafa.Text = "0";
            lblPistola.Text = "0";
            Program.partidaEstado.jogador.mao.ForEach((carta) => {
                switch (carta.tipo) {
                    case TipoCartaEnum.Esqueleto:
                        this.lblEsqueleto.Text = carta.quantidade.ToString();
                        break;
                    case TipoCartaEnum.Faca:
                        this.lblFaca.Text = carta.quantidade.ToString();
                        break;
                    case TipoCartaEnum.Tricornio:
                        this.lblTricornio.Text = carta.quantidade.ToString();
                        break;
                    case TipoCartaEnum.Garrafa:
                        this.lblGarrafa.Text = carta.quantidade.ToString();
                        break;
                    case TipoCartaEnum.Chave:
                        this.lblChave.Text = carta.quantidade.ToString();
                        break;
                    case TipoCartaEnum.Pistola:
                        this.lblPistola.Text = carta.quantidade.ToString();
                        break;
                }
            });
        }

        public void hideLobby() {
            btnIniciarPartida.Hide();
            lstPlayersLobby.Hide();
            btnHistorico.Show();
            pnlMadeira.Show();

            pnlChave.Show();
            pnlEsqueleto.Show();
            pnlFaca.Show();
            pnlGarrafa.Show();
            pnlPistola.Show();
            pnlTricornio.Show();

            lblChave.Show();
            lblEsqueleto.Show();
            lblFaca.Show();
            lblGarrafa.Show();
            lblPistola.Show();
            lblTricornio.Show();

            lblCartaSelecionada.Show();
            lblPosicaoSelecionada.Show();
            lblComunicacao.Show();
        }

        public void showLobby() {
            btnIniciarPartida.Show();
            lstPlayersLobby.Show();
            HistoricoGrid.Hide();
            pnlMadeira.Hide();

            btnHistorico.Hide();
            btnJogar.Hide();
            btnAuto.Hide();
            btnVoltar.Hide();

            pnlChave.Hide();
            pnlEsqueleto.Hide();
            pnlFaca.Hide();
            pnlGarrafa.Hide();
            pnlPistola.Hide();
            pnlTricornio.Hide();

            lblChave.Hide();
            lblEsqueleto.Hide();
            lblFaca.Hide();
            lblGarrafa.Hide();
            lblPistola.Hide();
            lblTricornio.Hide();

            lblCartaSelecionada.Hide();
            lblPosicaoSelecionada.Hide();
            lblComunicacao.Hide();
        }


        public void tileClick(object sender, EventArgs e) {
            Panel o = (Panel)sender;
            int prov = int.Parse(o.Tag.ToString().Split(',')[0].Split(':')[1]);
            var countPiratas = Program.partidaEstado.casas[prov];
            if (countPiratas.piratasPresentes.ContainsKey(Program.partidaEstado.jogador.id) &&
                countPiratas.piratasPresentes[Program.partidaEstado.jogador.id] > 0) {
                this.lblPosicaoSelecionada.Text = prov.ToString();
            }
            else {
                MessageBox.Show("Você n tem piratas nessa casa");
            }
            timerRoutine(null, null);
        }

        public void cardClick(object sender, EventArgs e) {
            Button o = (Button) sender;
            if (lblCartaSelecionada.Text != "x" && lblCartaSelecionada.Text == o.Tag.ToString()) {
                this.lblCartaSelecionada.Text = "x";
            }
            else {
                this.lblCartaSelecionada.Text = new Carta(o.Tag.ToString().Substring(0, 1)).tipo.ToString();
            }
            timerRoutine(null, null);
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            int posicao = (Utils.isStringValid(lblPosicaoSelecionada.Text.Replace("x", "")) ? int.Parse(lblPosicaoSelecionada.Text.Replace("x", ""))
                : -1);
            GameCore.jogar(Program.partidaEstado, posicao, Carta.GetTipoCartaEnum(lblCartaSelecionada.Text.Substring(0, 1)));
            timerRoutine(null, null);
            drawPiratas();
        }

        private void btnAuto_Click(object sender, EventArgs e) {
            Engine.process();
            timerRoutine(null, null);
            drawPiratas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            int posicao = (Utils.isStringValid(lblPosicaoSelecionada.Text.Replace("x", "")) ? int.Parse(lblPosicaoSelecionada.Text.Replace("x", ""))
    : -1);
            GameCore.voltar(Program.partidaEstado, posicao);
            timerRoutine(null, null);
            drawPiratas();
        }

        private void checkButtons() {
            if (Program.partidaEstado.idJogadorAtual == Program.partidaEstado.jogador.id) {
                lblComunicacao.Text = "É a sua vez. Jogadas restantes: " + (4 - Program.partidaEstado.rodadaAtual);
                this.btnJogar.Show();
                btnJogar.Text = "Pular";
                this.btnAuto.Show();

                if (Utils.isStringValid(lblPosicaoSelecionada.Text.Replace("x", ""))) {
                    btnVoltar.Show();

                    if (Utils.isStringValid(lblCartaSelecionada.Text.Replace("x", ""))) {
                        btnJogar.Text = "Jogar";
                    }
                }
            }
            else {
                lblComunicacao.Text = "É a vez do jogador " +
                                      GameCore.getPlayerName(Program.partidaEstado.id,
                                          Program.partidaEstado.idJogadorAtual);
                this.btnJogar.Hide();
                btnVoltar.Hide();
                this.btnAuto.Hide();
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e) {
            GameCore.iniciarPartida(Program.partidaEstado);
            if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
                hideLobby();
                drawTabuleiro();
                createPiratesZeroPoint();//////
                listarHistorico();
                checkButtons();
                updateMao();
            }
            else {
                MessageBox.Show("ERRO!", "Um erro inesperado ocorreu, a partida não foi iniciada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void showQtd(object sender, EventArgs e) {
            switch (((System.Windows.Forms.Button)sender).Tag) {
                case "G": {
                    this.pnlGarrafa.BackgroundImage = null;
                    break;
                }
                case "T": { // Tricornio
                    this.pnlTricornio.BackgroundImage = null;
                    break;
                }
                case "P": {
                    this.pnlPistola.BackgroundImage = null;
                    break;
                }
                case "E": { // Esqueleto(Jolly roger)
                    this.pnlEsqueleto.BackgroundImage = null;
                    break;
                }
                case "F": {
                    this.pnlFaca.BackgroundImage = null;
                    break;
                }
                case "C": {
                    this.pnlChave.BackgroundImage = null;
                    break;
                }
                default: break;
            }
        }

        private void setDefault(object sender, EventArgs e) {
            switch (((System.Windows.Forms.Button)sender).Tag) {
                case "G": {
                    this.pnlGarrafa.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Garrafa, false);
                    break;
                }
                case "T": { // Tricornio
                    this.pnlTricornio.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Tricornio, false);
                    break;
                }
                case "P": {
                    this.pnlPistola.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Pistola, false);
                    break;
                }
                case "E": { // Esqueleto(Jolly roger)
                    this.pnlEsqueleto.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Esqueleto, false);
                    break;
                }
                case "F": {
                    this.pnlFaca.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Faca, false);
                    break;
                }
                case "C": {
                    this.pnlChave.BackgroundImage = Carta.GetCardBitmap(TipoCartaEnum.Chave, false);
                    break;
                }
                default: break;
            }
        }


        // =========== Renderização =============>

        private void drawPiratas() {

            // Cria parametros de localizacao
            int marginLeft = 60;
            int marginTop = 55;
            int espY = 27;
            int espX = 42;
            int h = 65;
            int w = 65;

            Dictionary<int, int> map = new Dictionary<int, int>();
            Dictionary<int, int> order = new Dictionary<int, int>();

            // Itera casas da partida
            Program.partidaEstado.casas.Keys.ToList().ForEach((key) => {
                int k = key - ((key / 6) * 6);
                int i = key / 6;
                int piratas = 1;

                // Pega casa e itera piratas de jogadores naquela casa
                Program.partidaEstado.casas[key].piratasPresentes.Keys.ToList().ForEach((innerKey) => {
                    if (!map.Keys.ToList().Contains(innerKey))
                    {
                        map.Add(innerKey, 0);

                        if (!order.Keys.Contains(innerKey))
                        {
                            order.Add(innerKey, order.Values.Count > 0 && order.Values.ToList().Max() > 0 ? order.Values.ToList().Max(): 0);
                        }
                    }
                    if (key > 0 && key <= 37) {

                        // Itera piratas de um jogador especifico
                        for (int d = 0, ordem = 0; d < Program.partidaEstado.casas[key].piratasPresentes[innerKey]; d++) {
                            // Cria desenho do pirata
                            Panel p = this.Controls.OfType<Panel>().ToList().Find((panel) => (panel.Tag != null) && (innerKey + "." + map[innerKey] == panel.Tag.ToString()));

                            int top = (piratas == 1 ? w : (w / 4));
                            int left = (piratas == 1 ? (w / 4) : (piratas == 2 ? (w / 2) : (w * (3 / 4))));

                            if(key < 37)
                            {
                                p.Top = (top + marginTop + espY + (h + espY) * (i % 2 == 0 ? k : 5 - k)) - 25;
                                p.Left = (left + marginLeft + espX + (h + espX) * i) - 10;
                            }
                            else
                            {
                                p.Top = 15 + (55 * order[innerKey]);
                                p.Left = 785 + (40 * d);
                            }

                            p.BringToFront();
                            this.Controls.SetChildIndex(p, 0);
                            piratas++;
                            map[innerKey]++;
                        }
                    } else if(key == 37)
                    {
                        //785; 15 -> piratas
                    }
                });
            });
        }

        private void createPiratesZeroPoint()
        {
            HashSet<int> jogadoresPresentes = new HashSet<int>();
            foreach (var casa in Program.partidaEstado.casas.Values.ToList()) {
                casa.piratasPresentes.Keys.ToList().ForEach((key) => {
                    jogadoresPresentes.Add(key);
                });
                if (jogadoresPresentes.Count >= 4) {
                    break;
                }
            }

            int order = 0;
            jogadoresPresentes.ToList().ForEach((idJogador) => {
                for (int i=1; i <=6; i++) {
                    Panel p = new Panel();
                    p.BackgroundImage = Color.getPirate((Color.ColorEnum) order);
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.Tag = idJogador.ToString() + "." + (i-1);
                    p.Height = 42;
                    p.Width = 30;

                    p.Top = (order > 1 ? 325 : 0) + (50 * (i-1));
                    p.Left = (order > 0 ? 35 : 0);

                    this.Controls.Add(p);
                    p.BringToFront();
                    this.Controls.SetChildIndex(p, 0);
                }
                order++;
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

                if(((6 * i) + k) < 37)
                {
                    Panel tile = new Panel();
                    tile.BackgroundImage = Carta.GetCardBitmap(Program.partidaEstado.casas[(6 * i) + k].tipoPosicao, true);
                    tile.BackgroundImageLayout = ImageLayout.Stretch;
                    tile.BackColor = System.Drawing.Color.Transparent;
                    tile.Top = marginTop + espY + (h + espY) * (i % 2 == 0 ? k : 5 - k);
                    tile.Left = marginLeft + espX + (h + espX) * i;
                    tile.Cursor = System.Windows.Forms.Cursors.Hand;
                    tile.Width = w;
                    tile.Height = h;

                    tile.Tag = "i:" + ((6 * i) + k);
                    tile.Click += tileClick;
                    this.Controls.Add(tile);
                    this.Controls.SetChildIndex(tile, 1);
                }
            });
        }

        private void btnHistorico_Click(object sender, EventArgs e) {
            HistoricoGrid.Visible = !HistoricoGrid.Visible;
        }

        private void listarHistorico() {
            var jogadas = JogadaAntiga.VerHistorico(Program.partidaEstado);
            if (Program.partidaEstado.jogadasAntigas == null || jogadas.Count > Program.partidaEstado.jogadasAntigas.Count)
            {
                drawPiratas();
            }
            Program.partidaEstado.jogadasAntigas = jogadas;
            this.HistoricoGrid.Rows.Clear();
            Program.partidaEstado.jogadasAntigas.ForEach((partida) => {
                this.HistoricoGrid.Rows.Add(partida.id.ToString(), partida.numJogada.ToString(),
                    Carta.GetTipoCartaEnum(partida.simbolo).ToString(), partida.posOrigem, partida.posDestino);
            });
        }
    }
}
