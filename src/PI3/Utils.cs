namespace PI3{
    
    public class Utils{

        public static string firstToUpper(string str) {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}