using PI3.models;
using System;
//using System.Text.Json.Serialization;
using System.IO;
//using System.Text.Json;
using System.Windows.Forms;

namespace PI3
{
    internal static class Program{

        public static Partida partidaEstado = null;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // try {
            //     string json = File.ReadAllText(Path.DirectorySeparatorChar + "partidaEstado.json");
            //     if (json.Length > 0) {
            //         partidaEstado = JsonSerializer.Deserialize<Partida>(json, new JsonSerializerOptions {NumberHandling = JsonNumberHandling.AllowReadingFromString});
            //         GameCore.update(partidaEstado);
            //     }
            //
            //     if (partidaEstado != null && partidaEstado.state == PartidaState.PartidaEnum.ABERTA || partidaEstado.state == PartidaState.PartidaEnum.INICIADA) {
            //         Utils.ConsoleLogInfo("UMa partida chamada " + partidaEstado.name + " e de ID " + partidaEstado.id +  " foi identificada na inicialização.");
            //     } else {
            //         Utils.ConsoleLogInfo("Nenhuma partida identificada.");
            //         partidaEstado = null;
            //     }
            //     Application.Run(new Menu());
            // } catch (Exception e) {
            //     Utils.ConsoleLogInfo("Nenhuma partida identificada.");
            Application.Run(new Menu());
            //Application.Run(new FimPartida());
            // }

            //Application.Run(new Form1());
            //Posicao p = new Posicao(Carta.GetTipoCartaEnum("P")); 
            //Console.WriteLine(p);
        }
    }
}
