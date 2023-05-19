using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI3.components.tabuleiro;
using CartagenaServer;
using PI3.models;

namespace PI3
{
    internal static class Program
    {

        public static Partida partidaEstado;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            //Application.Run(new TabuleiroForm(partidaEstado));
            //Application.Run(new Form1());
        }
    }
}
