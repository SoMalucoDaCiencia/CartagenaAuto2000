using System;
using System.Runtime.InteropServices;

namespace PI3{
    public class Utils{
        public static string firstToUpper(string str) {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public static string[] splitByString(string str, string sub) {
            return str.Split(new [] { sub }, StringSplitOptions.None);
        }

        public static void checkError(string serverResponse) {
            if (serverResponse.Contains("Erro")) {
                throw new ExternalException(Utils.splitByString(serverResponse, "Erro:")[1]);
            }
        }
    }
}
