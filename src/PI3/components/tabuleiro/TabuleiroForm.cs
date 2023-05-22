using System;
using System.Windows.Forms;
using PI3.models;

namespace PI3.components.tabuleiro {

    public partial class TabuleiroForm : Form {

        Timer timer = new Timer();

        int posicaoSelecionada = -1;

        Carta cartaSelecionada = null;

        bool initModalView = false;

        public TabuleiroForm() {
            timer.Tick += ((obj, args) => {
                GameCore.update(Program.partidaEstado);
                if (Program.partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
                    initModalView = false;
                    this.render();
                } else {
                    initModalView = true;
                    // ...Draw init list
                }
            });
            timer.Interval = 5000;
            timer.Start();
        }

        private void render() {
            InitializeComponent();
            setTabuleiro();
            setCartas();
            checkButtons();
        }

        private void setTabuleiro() {
            for (int i = 0; i < 6; i++) {
                for (int k = 0; k < 6; k++) {
                    Panel p = new Panel();
                    int marginTop = 0;
                    int marginLeft = 0;
                    int h = 80; //ç
                    int w = 80;
                    int esp = 20;
                    p.BackgroundImage = Carta.GetCardBitmap(Program.partidaEstado.casas[(6 * i) + k].tipoPosicao);
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.Top = marginTop + esp + (h + esp) * ((i % 2 == 0 ? 0 : 5) + (k * (i % 2 == 0 ? 1 : -1)));
                    p.Left = marginLeft + esp + (h + esp) * i;
                    p.Width = w;
                    p.Height = h;


                    p.Tag = "i:" + ((6 * i) + k) +
                        ",x1:" + (p.Left + (w/4)) +
                        ",x2:" + (p.Left + (w/2)) +
                        ",x3:" + (p.Left + (w*3/4)) +
                        ",y1:" + (p.Top -  (w*3/4)) +
                        ",y2:" + (p.Top - (w/4)) +
                        ",y3:" + (p.Top - (w*3/4));

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
                p.BackgroundImage = Carta.GetCardBitmap(carta.tipo);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Top = esp + (i > 2 ? (esp + h) : 0);
                p.Left = esp + ((i % 3) * w);
                p.Width = w;
                p.Height = h;

                p.Tag = carta.ToString();
            });
        }

        public void tileClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.posicaoSelecionada = int.Parse(o.Tag.ToString().Split(',')[0].Split(':')[1]);
            GameCore.update(Program.partidaEstado);
            checkButtons();
        }

        public void cardClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.cartaSelecionada = new Carta(o.Tag.ToString().Substring(0, 1));
            GameCore.update(Program.partidaEstado);
            checkButtons();
        }

        private void btnEnter_Click(object sender, EventArgs e) {

        }

        private void btnAuto_Click(object sender, EventArgs e) {

        }

        private void checkButtons() {
            if (Program.partidaEstado.idJogadorAtual == Program.partidaEstado.jogador.id) {
            	this.btnEnter.Enabled = true;
            	this.btnAuto.Enabled = true;
            }
        }
    }
}










