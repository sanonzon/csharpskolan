using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length != 1){
                Console.WriteLine("Skriv 1 tal som argument.");
                Environment.Exit(-1); 
            }

            double x = 0;
            try {
                x = double.Parse(args[0]);
            }catch(FormatException){
                Console.WriteLine("Argumentet är inte ett tal.");
                Environment.Exit(-1);
            }
            
            Console.WriteLine(string.Format("123.321 * {0} = {1}",args[0],(x*123.321).ToString()));

        }
    }
}
