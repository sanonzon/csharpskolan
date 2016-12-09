using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppg4{
    class Program{
        public abstract class hasMultiplication<T>{ // Detta är en generic som har en typ-parameter T.
            public abstract T multiply(Heltal b);  // Vi måste kunna multiplicera.
            public abstract T one();          // Måste finnas ett ett-tal.
            public abstract T zero();         //         och ett noll-tal.
        }
        public class Heltal : hasMultiplication<Heltal> {  // Detta är ett sätt att ärva "krav" på funktionalitet för vår klass Heltal.
            private int m;
            public Heltal(int a) { m = a; Singleton.addToList(this);}
            static public   Heltal operator*(Heltal a, Heltal b){return a.multiply(b);}
            public override string ToString(){
                return m.ToString();
            }
            public override Heltal multiply(Heltal t){
                return new Heltal(m*t.getInt());
            }
            public override Heltal one(){                
                return new Heltal(1);
            }
            public override Heltal zero(){
                return new Heltal(0);
            }
            public int getInt(){
                return m;
            }
        }
        class Singleton{
            private Singleton() { } // Vi gör konstruktorn privat så vi inte kan skapa objekt själva.
            public static Singleton GetInstance(){ // Den här statiska funktionen ska ge oss ett objekt om vi ber snällt.
                if (mInstance == null)
                    mInstance = new Singleton(); // Om det är första gången vi försöker komma åt objektet, Se till att det skapas.
                return mInstance;
            }
            
            private static Singleton mInstance = null;  // En privat statisk medlemsvariabel försäkrar att vi endast via GetInstance kan komma åt objekt av denna typen.

            private static List<Heltal> listan;
            public static void addToList(Heltal h){
                listan.Add(h);
            }
            
            public void PrintaListan(){
                foreach(Heltal h in listan){
                    Console.WriteLine(h.ToString());
                }
            }
        }


        static void Main(string[] args){
            //Singleton s = new Singleton();  // Testa detta! ( Ska inte funka )
            Singleton s = Singleton.GetInstance();  // Detta funkar bättre!

            Heltal a = new Heltal(2);
            Console.WriteLine(a * a);  

            s.PrintaListan();

            new Heltal(3);
            new Heltal(7);

            s.PrintaListan();
            // Utför här några experiment där ni räknar ut och skapar nya heltal kopplade till singelton-logger
            // och undersöker så att listan uppdateras som den ska.
        }
    }
}
