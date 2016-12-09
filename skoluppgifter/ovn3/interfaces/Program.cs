using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public interface Djur {
        string Name {
            get;
            set;
        }
        int Legs{
            get;
            set;
        }
        int Tails{
            get;
            set;            
        }
        bool Fly{
            get;
            set;            
        }
        bool Swim{
            get;
            set;
        }
        bool Walk{
            get;
            set;
        }
        bool Tame{
            get;
            set;
        }
    }


    public class MeraDjurOrkarInteGoraEnForVarje : Djur{
        private string name;
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public string Name {
            get {return name;}
            set{name = value;}
        }
        public bool Walk{
            get{return canWalk;}
            set{canWalk=value;}
        }
        public bool Swim{
            get{return canSwim;}
            set{canSwim=value;}
        }
        public bool Fly{
            get{return canFly;}
            set{canFly=value;}
        }
        public bool Tame{
            get{return tame;}
            set{tame = value;}
        }
        public int Legs{
            get{return legs;}
            set{legs=value;}
        }
        public int Tails{
            get{return tails;}
            set{tails=value;}
        }
        public MeraDjurOrkarInteGoraEnForVarje(string name, bool tame, int legs, int tails, bool fly, bool walk, bool swim){
            Name = name;
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }
   
    public class Program {
        public static void Main(string[] args){
            List<Djur> djur = new List<Djur>();

            // constructor for class(string name, bool tame, int legs, int tails, bool fly, bool walk, bool swim){
               
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("lejonpappan",false,3,2,false,true,true));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Katt",true,3,1,true,false,false));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Varg",false,3,1,true,false,false));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Anka",false,2,1,true,true,true));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Hund",false,0,1,true,false,false));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Boaorm",false,0,1,true,false,true));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Människa",false,1,1,true,false,false));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Fisk",false,0,1,true,true,true));
            djur.Add(new MeraDjurOrkarInteGoraEnForVarje("Haj",false,10,0,true,false,false));
            
            
            Console.WriteLine("Dessa konstiga djur Simma och Gå och har minst 2 ben.");
            foreach(Djur d in djur){
                if(d.Walk && d.Swim && d.Legs >= 2){
                    Console.WriteLine(d.Name);
                }
            }

        
            Console.WriteLine("Dessa konstiga djur kan Flyga, har mer än 1 ben och 1 svans.");
            foreach(Djur d in djur){
                if(d.Fly && d.Legs > 1 && d.Tails == 1){
                    Console.WriteLine(d.Name);
                }
            }
            
            

        }
    }
}
