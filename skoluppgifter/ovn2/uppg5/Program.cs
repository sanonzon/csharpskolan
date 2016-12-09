using System;
using System.Collections;
namespace ConsoleApplication{
    public class Inteint{
        private int inteint;
        public Inteint(){
            inteint = 0;
        }
        public Inteint(int i){
            inteint = i;
        }
        public static string operator/(Inteint u, object op){    
            string s = "";        
            IDictionary listAllTheThings =Environment.GetEnvironmentVariables(); 
            /*
            foreach(DictionaryEntry de in listAllTheThings){
                s+= string.Format("{0}: {1}\n",de.Key, de.Value);
            } 
            */           
            if(listAllTheThings.Contains("LOGNAME")){
                s+= string.Format("The dark is forced within dis wan, {0}.",listAllTheThings["LOGNAME"]);
            }
            else {
                s+= "no name such fail, blue violets.";
            }
            return s;
        }
        public static byte[] operator-(Inteint u, object op){
            byte[] lol = new byte[]{1,1,0,0,0,1,1,0,0,1,1,1,0,0,0,1};
            return lol;
        }
        public static string operator+(Inteint u, string s){
            string asdf = "";
            string [] hehehe = new string[]{"I", "Like", "Big", "Butts", "And", "I", "Cannot", "Lie"};
            for(int i =0; i < hehehe.Length; i++){
                if(i > 0){
                    asdf += new string('\t',i);
                }
                asdf += string.Format("{0}\n",hehehe[i]);
            }
            
            return asdf;
        }
        public static string operator*(Inteint u, object op){
            string s = "";
            int height = 12;            
            for(int i = 0; i< height; i++) { // rows
                for (int o = 0; o <height; o++) {
                    if(o >= height-i){
                        s+= "*";
                    }else{
                        s += " ";
                    }
                }
                if (i > 0){
                    s+= new string('*',i-1);
                }
                
                s+= "\n";
            }
            for(int i = 0; i < height*2; i++){
                if(i == height -3 || i == height +1 ){
                    s+= "|";
                }else{
                    s+= " ";
                }
            }
            return s;
        }
    }
    public class Program{
        public static void Main(string[] args){
            Inteint dooooooot = new Inteint();
            Console.WriteLine(dooooooot+"lol");
            Console.WriteLine(dooooooot/"slapchop");
            
            Console.Write("\t");
            byte[] ggg = dooooooot-12;
            int counter = 0;
            foreach(byte g in ggg){
                Console.Write(g.ToString());
                counter++;
                if (counter % 2 == 0){
                    Console.Write(" ");                    
                }
            } 
            Console.WriteLine();

            Console.WriteLine(dooooooot * 1234);

        }
    }
}
