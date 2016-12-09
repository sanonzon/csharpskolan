using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 10 tal separerat på mellanslag.");
            string s = Console.ReadLine();
            string[] tal = s.Split(' ');
            double[] talen = new double[10];            
            int counter = 0;
            foreach(string t in tal){
                try {
                    double d = double.Parse(t);
                    talen[counter] = d;
                    counter++;
                }catch(FormatException){
                    Console.WriteLine(string.Format("'{0}' är inget tal.",t));
                    Environment.Exit(-1);                
                }
            }
            for(int i = talen.Length-1; i > 0; i--){
                Console.Write(talen[i] + " ");
            }
            Console.WriteLine("");

        }
    }
}
