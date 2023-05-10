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
    public partial class Tabuleiro : Form
    {
        public Tabuleiro()
        {
            InitializeComponent();
            ControlBox = false; //tira os negocios da janela do form
        }
    }
}
