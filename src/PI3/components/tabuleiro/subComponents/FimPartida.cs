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
    public partial class FimPartida : Form
    {
        private string winner;

        public FimPartida(string winner)
        {
            InitializeComponent();
            //vencedor();
            this.winner = winner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.partidaEstado = null;
            this.Controls.Clear();
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        public void vencedor()
        {
            lblJogador.Text = GameCore.getPlayerName(Program.partidaEstado.id, Program.partidaEstado.jogador.id);
        }
    }
}
