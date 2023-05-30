using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.models
{
    public class JogadaAntiga
    {
        public int id { get; set; }

        public int numJogada { get; set; }

        public string simbolo { get; set; }

        public string posOrigem { get; set; }

        public string posDestino { get; set; }

        public JogadaAntiga(int idJogador, int nJogada, string simboloCarta, string posicaoOrigem, string posicaoDestino)
        {
            this.id = idJogador;
            this.numJogada = nJogada;
            this.simbolo = simboloCarta;
            this.posOrigem = posicaoOrigem;
            this.posDestino = posicaoDestino;
        }

        public static List<JogadaAntiga> VerHistorico(Partida partida)
        {
            try
            {
                string serverResponse = Jogo.ExibirHistorico(partida.id);
                Utils.checkError(serverResponse);

                List<JogadaAntiga> ret = new List<JogadaAntiga>();
                List<string> list = new List<string>(serverResponse.Replace("\r", "").Split('\n'));
                list.ForEach((str) => {
                    if (str != "")
                    {
                        var arr = str.Split(',');
                        ret.Add(new JogadaAntiga(int.Parse(arr[0]), int.Parse(arr[1]), arr[2], arr[3], arr[4]));
                    }

                });

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Um erro inesperado ocorreu, tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
