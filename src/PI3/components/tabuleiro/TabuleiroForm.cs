using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.components.tabuleiro
{
    public partial class TabuleiroForm : Form
    {
        public TabuleiroForm()
        {
            InitializeComponent();
            ControlBox = false; //tira os negocios da janela do form
            attachClickEventHandler();
        }
        private void attachClickEventHandler()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < 6; k++)
                {
                    Panel p = new Panel();
                    p.BackgroundImage = Properties.Resources.MainBackground;
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.Top = 20 + 120 * ((i % 2 == 0 ? 0 : 5) + (k * (i % 2 == 0 ? 1 : -1)));
                    p.Left = 20 + 120 * i;
                    p.Width = 100;
                    p.Height = 100;


         p.Tag = "i:" + (6 * i + (k + i)) +
                 ",x1:" + (p.Left + 25) +
                 ",x2:" + (p.Left + 50) +
                 ",x3:" + (p.Left + 75) +
                 ",y1:" + (p.Top - 75) +
                 ",y2:" + (p.Top - 25) +
                 ",y3:" + (p.Top - 75);
          
         p.Click += tileClick;

                    // Precisa ver onde vai adicionar
                    //
                    //flowLayoutPanel1.Controls.Add(p);
                    //
                    // ou
                    //
                    this.Controls.Add(p);
                }
            }
        }

        public void tileClick(object sender, EventArgs e)
        {
            // do click stuff
            Panel o = (Panel)sender;
            Console.WriteLine(o.Tag.ToString());
        }
    }
}
