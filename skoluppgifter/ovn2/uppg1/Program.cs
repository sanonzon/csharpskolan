using System;

namespace ConsoleApplication{
    public class Braindoot{
        string doot;

        public Braindoot(String s){
            this.doot=s;
        }

        public static Braindoot operator*(Braindoot bd, String s){
            return new Braindoot(string.Format("{0}{1}",bd.doot,s));
        }
        public string getString(){
            return this.doot;
        }

    };

    public class Program{
        public static void Main(string[] args){            
            Braindoot doot = new Braindoot("dootface");
            string asdf = "wertyuio";
            Console.WriteLine("doot: " + doot.getString());;
            Console.WriteLine("asdf: " + asdf);
            
            Console.WriteLine((doot*asdf).getString());
            
        }
    }
}
