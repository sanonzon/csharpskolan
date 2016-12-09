using System;

// Fråga om två heltal, skriv ut * / + - av dem.
namespace ConsoleApplication{
    public class Program    {
        public static string plus(int x, int y){            
            return (x+y).ToString();
        }
        public static string minus(int x, int y){
            return (x-y).ToString();
        }
        public static string mult(int x, int y){
            return (x*y).ToString();
        }
        public static string div(int x, int y){
            int i = x/y;
            int rest = x%y; 
            return "" + i.ToString() + ", rest " + rest.ToString();
        }
        public static string testInput(string[] args) {
            string fails = "";
            foreach(string arg in args) {
                try {
                    int.Parse(arg);
                }catch(FormatException){
                    fails += "\n" + arg + " är inte ett heltal.";
                }            
            }
            return fails;
        } 
        public static void Main(string[] args) {
            Console.WriteLine("Mata in 2 heltal, separerat med mellanslag/blanksteg.");
            while((args = Console.ReadLine().Split(' ')).Length != 2){
                Console.WriteLine("Mata in 2 heltal, separerat med mellanslag/blanksteg.");
            }
            
            string fails = testInput(args); 
            if (fails.Length>0){
                Console.WriteLine(fails);
                Environment.Exit(-1);
            }
            int nOne = int.Parse(args[0]);
            int nTwo = int.Parse(args[1]);

            Console.WriteLine(string.Format("{0} {1} {2} = {3}",nOne,"+",nTwo,plus(nOne,nTwo)));
            Console.WriteLine(string.Format("{0} {1} {2} = {3}",nOne,"-",nTwo,minus(nOne,nTwo)));
            Console.WriteLine(string.Format("{0} {1} {2} = {3}",nOne,"*",nTwo,mult(nOne,nTwo)));
            Console.WriteLine(string.Format("{0} {1} {2} = {3}",nOne,"/",nTwo,div(nOne,nTwo)));

        }
    }
}
