using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> doot = new List<int>();
            Console.WriteLine("Skriv in ett gäng tal, ett i taget");
            while(true){
                String s = Console.ReadLine();
                try {
                    int.Parse(s);
                }catch(FormatException){
                    break;
                }
                doot.Add(int.Parse(s));
            }
            int sum = 0;
            foreach(int i in doot){
                sum += i;
            }
            Console.WriteLine(string.Format("Summan av alla tal är {0}",sum));

        }
    }
}
