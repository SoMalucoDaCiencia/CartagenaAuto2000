using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.components.tabuleiro {
	
    public partial class TabuleiroForm : Form {
    
    	Partida partida = null

        int posicaoSelecionada = -1;
        
        Carta cartaSelecionada = null;
    
        public TabuleiroForm(Partida partida) {
        	this.partida = partida;
        	this.parttida.updateTable();
            InitializeComponent();
            this.btnEnter.Enabled = false;
            this.btnAuto.Enabled = false;
            setTabuleiro();
            setCartas()
        }
        
        private void setTabuleiro() {
            for (int i = 0; i < 6; i++) {
                for (int k = 0; k < 6; k++) {
                    Panel p = new Panel();
                    int h = 60;
                    int w = 60;
                    int esp = 15;
                    p.BackgroundImage = Properties.Resources.MainBackground;
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.Top = esp + (h + esp) * ((i % 2 == 0 ? 0 : 5) + (k * (i % 2 == 0 ? 1 : -1)));
                    p.Left = esp + (h + esp) * i;
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
            this.parttida.jogador.mao.forEach((carta) => {
                Panel p = new Panel();
                int h = 60;
                int w = 60;
                int esp = 15;
                p.BackgroundImage = Carta.GetCardBitmap();                
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Top = esp + (i > 2 ? (esp + h) : 0)
                p.Left = esp + ((i%3) * w)
                p.Width = w;
                p.Height = h;
                
                p.Tag = carta.ToString()
            });
        }

        public void tileClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.posicaoSelecionada = int.Parse(o.Tag.ToString().Split(',')[0].Split(':')[1])
            this.partida.update()
            if (this.partida.idJogadorAtual == this.partida.jogador.id) {
            	this.btnEnter.Enabled = true;
            	this.btnAuto.Enabled = true;
            }
            
        }
        
        public void cardClick(object sender, EventArgs e) {
            Panel o = (Panel) sender;
            this.cartaSelecionada = new Carta(o.Tag.ToString().Substring(0, 1))
            this.partida.update()
            if (this.partida.idJogadorAtual == this.partida.jogador.id) {
            	this.btnEnter.Enabled = true;
            	this.btnAuto.Enabled = true;
            }
        }
    }
}










