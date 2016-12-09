using System;
/*
* Programmet räknar ut kvadraten på tal mellan 0 till 10.
*/
namespace ConsoleApplication {
    public class Program {
        public static void Main(string[] args) {
            for (int i = 0; i <= 10; i++) {
                Console.Write(string.Format("{0}, ",i*i));
            };
        }
    }
}
