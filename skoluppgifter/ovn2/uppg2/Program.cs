using System;

namespace ConsoleApplication
{
    public class Gnirts
    {
        string gnirts = "";
        public override string ToString(){            
            string s = "";
            for(int i = gnirts.Length-1; i >=0; i--){
                s+= gnirts[i];
            }
            return s;
        }
        public Gnirts(string s){
            gnirts = s;
        }
        public static void Main(string[] args)
        {
            Console.Write("Mata in en textsträng: ");
            string s = Console.ReadLine();
            Gnirts g = new Gnirts(s);
            Console.WriteLine("Baklänges blir det: {0}",g.ToString());
        
        }
    }
}
