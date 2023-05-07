using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3{
    public partial class Menu : Form{
        public Menu() {
            InitializeComponent();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Navegacao navegacao = new Navegacao();
            navegacao.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}