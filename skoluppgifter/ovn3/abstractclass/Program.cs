using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public abstract class Djur{
        public abstract string sayStuff();
        public abstract bool getTame();
        public abstract int getLegs();
        public abstract int getTails();
        public abstract bool getSwim();
        public abstract bool getWalk();
        public abstract bool getFly();
        
        
    }
    public class Lejon : Djur{
        string speak = "Doot doot im a furry lion.";
        bool tame = false;
        bool canSwim = false;
        bool canFly = false;
        bool canWalk = false;
        int legs = 3;
        int tails = 5;
        public override string sayStuff(){
            return speak;
        }
        public override bool getTame(){
            return tame;
        }
        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }

  
    }
    public class Katt: Djur {
        string speak = "Meow, feed me.";
        bool tame = true;
        bool canSwim = false;
        bool canFly = true;
        bool canWalk = false;
        int legs = 3;
        int tails = 1;
        public override bool getTame(){
            return tame;
        }
        public override string sayStuff(){
            return speak;
        } 
      
        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Varg: Djur {
        string speak = "Woof is not the vargens sounds.";
        bool tame = false;
         bool canSwim = false;
        bool canFly = true;
        bool canWalk = true;
        int legs = 3;
        int tails = 2;
        public override string sayStuff(){
            return speak;
        } 
          public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Hund: Djur {
        string speak = "I like it doggy style.";
        bool canSwim = true;
        bool canFly = true;
        bool canWalk = false;
        
        bool tame = true;
        int legs = 1;
        int tails = 0;
        public override string sayStuff(){
            return speak;
        } 
         public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Anka: Djur {
        string speak = "Flap flap there is no fap.";
        
         bool canSwim = true;
        bool canFly = false;
        bool canWalk = true;
        int legs = 9;
        bool tame = false;
        int tails =0;
        public override string sayStuff(){
            return speak;
        } 
        public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }   
    public class Boaorm: Djur {
        string speak = "Ssssssssssssssssnake.";
        bool tame = false;
         bool canSwim = false;
        bool canFly = true;
        bool canWalk = false;
        int legs = 5;
        int tails = 3;
        public override string sayStuff(){
            return speak;
        } 
         public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Fisk: Djur {
        string speak = "Blubb blubb blubb.";
        
         bool canSwim = false;
        bool canFly = false;
        bool canWalk = false;
        int legs = 3;
        int tails = 5;
        bool tame = false;
        public override string sayStuff(){
            return speak;
        } 
        public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Haj: Djur {
        string speak = "In this version i can fly.";
        
         bool canSwim = true;
        bool canFly = true;
        bool canWalk = true;
        int legs = 0;
        int tails = 0;
        bool tame = false;
        public override string sayStuff(){
            return speak;
        } 
        public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    public class Människa: Djur {
        string speak = "Im the useless animal.";        
         bool canSwim = false;
        bool canFly = true;
        bool canWalk = false;
        int legs = 8;
        int tails = 1;
        bool tame = false;
        public override string sayStuff(){
            return speak;
        } 
        public override bool getTame(){
            return tame;
        }

        public override int getLegs(){
            return legs;
        }
        public override int getTails(){
            return tails;
        }
        public override bool getFly(){
            return canFly;
        }
        public override bool getSwim(){
            return canSwim;
        }
        public override bool getWalk(){
            return canWalk;
        }
    }
    
    
    public class doot{
        public static string NameOfStuff(Djur d){
            return d.ToString().Substring(d.ToString().LastIndexOf('.')+1);
        }
        public static void MinstAntalBen(List<Djur> djur, int legs){
            Console.WriteLine("\nDjur med minst {0} ben",legs);
            foreach(Djur d in djur){
                if (d.getLegs() >= legs){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }

        }
        public static void MinstAntalSvansar(List<Djur> djur, int svansar){
            Console.WriteLine("\nDjur med minst {0} svansar",svansar);
            foreach(Djur d in djur){
                if (d.getTails() >= svansar){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }

        }
        public static void TamaDjur(List<Djur> djur){
            Console.WriteLine("\nTama djur");
            foreach(Djur d in djur){
                if (d.getTame()){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }
        }
        public static void InteTamaDjur(List<Djur> djur){
            Console.WriteLine("\nINTE Tama djur");
            foreach(Djur d in djur){
                if (!d.getTame()){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }
        }

        public static void KanSimma(List<Djur> djur){
            Console.WriteLine("\nDjur som kan simma");
            foreach(Djur d in djur){
                if (d.getSwim()){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }
        }
        public static void KanFlyga(List<Djur> djur){
            Console.WriteLine("\nDjur som kan flyga");
            foreach(Djur d in djur){
                if (d.getFly()){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }
        }
        public static void KanGå(List<Djur> djur){
            Console.WriteLine("\nDjur som kan gå");
            foreach(Djur d in djur){
                if (d.getWalk()){
                    Console.WriteLine("\t{0}",NameOfStuff(d));
                }
            }
        }
        public static void Main(string[]args){
            List<Djur> animals = new List<Djur>();

            animals.Add(new Katt());
            animals.Add(new Lejon());
            animals.Add(new Människa());
            animals.Add(new Varg());
            animals.Add(new Hund());
            animals.Add(new Anka());
            animals.Add(new Boaorm());
            animals.Add(new Fisk());
            animals.Add(new Haj());


            MinstAntalBen(animals,3);
            KanSimma(animals);
            KanFlyga(animals);
            KanGå(animals);
            MinstAntalSvansar(animals,5);

            MinstAntalBen(animals,6);

            /*
            Console.WriteLine("\n\t more than 2 legs.");
            foreach(Djur d in animals){                                 
                if (d.getLegs() > 2){
                   Console.WriteLine(d.getName());
                }
            }

            Console.WriteLine("\n\tCan fly.");
            foreach(Djur d in animals){                                 
                if (d.getFly()){
                   Console.WriteLine(d.getName());
                }
            }

            Console.WriteLine("\nAnd these things and fly and have more than 1 legs and 1 tail.\n\t can fly && legs > 1 && tails == 1");
            foreach(Djur d in animals){                                 
                if (d.getLegs() > 1 && d.getFly() && d.getTails() == 1){
                   Console.WriteLine(d.getName());
                }
            }
 */
        }
    }
    
}
