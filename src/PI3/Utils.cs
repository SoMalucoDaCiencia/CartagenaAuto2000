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
            if (serverResponse.Contains("ERRO")) {
                throw new Exception(splitByString(serverResponse, "ERRO:")[1]);
            }
        }

        public static bool isStringValid(string str)
        {
            return str != null && str.Replace(" ", "").Length > 0;
        }

        public static void ConsoleLogInfo(String str) {
            Console.WriteLine(ConsoleColor.Yellow + "[CARTAGENA2000] - INFO - " + DateTime.Now + " --> " + str);
            Console.ResetColor();
        }

        public static void ConsoleLogErr(String str) {
            Console.WriteLine(ConsoleColor.Red + "[CARTAGENA2000] - ERROR - " + DateTime.Now + " --> " + str);
            Console.ResetColor();
        }
    }
}
