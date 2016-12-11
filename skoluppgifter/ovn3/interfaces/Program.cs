using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public interface Djur
    {
        int Legs { get; set; }
        int Tails { get; set; }
        bool Fly { get; set; }
        bool Swim { get; set; }
        bool Walk { get; set; }
        bool Tame { get; set; }
    }

    public class Haj : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Haj(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Lejon : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Lejon(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Katt : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;

        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Katt(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Varg : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Varg(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Hund : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Hund(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Anka : Djur
    {

        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Anka(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Boaorm : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;

        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Boaorm(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Fisk : Djur
    {
        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Fisk(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Människa : Djur
    {

        private bool canWalk;
        private bool canSwim;
        private bool canFly;
        private int legs;
        private int tails;
        private bool tame;
        public bool Walk
        {
            get { return canWalk; }
            set { canWalk = value; }
        }
        public bool Swim
        {
            get { return canSwim; }
            set { canSwim = value; }
        }
        public bool Fly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public bool Tame
        {
            get { return tame; }
            set { tame = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public int Tails
        {
            get { return tails; }
            set { tails = value; }
        }
        public Människa(bool tame, int legs, int tails, bool fly, bool walk, bool swim)
        {
            Tame = tame;
            Legs = legs;
            Tails = tails;
            Fly = fly;
            Swim = swim;
            Walk = walk;
        }
    }

    public class Program
    {
        public static string getName(Djur d)
        {
            return d.ToString().Substring(d.ToString().LastIndexOf(".") + 1);
        }
        public static void DjurSomKanSimma(List<Djur> djur)
        {
            Console.WriteLine("\nDjur som kan simma:");
            foreach (Djur d in djur)
            {
                if (d.Swim)
                {
                    Console.WriteLine("\t{0}", getName(d));
                }
            }
        }

        public static void DjurSomKanSimmaOchHarFlerBenÄnEttOchEnSvans(List<Djur> djur)
        {
            Console.WriteLine("\nDjur som kan simma och har fler ben än 1 och en svans.");
            foreach (Djur d in djur)
            {
                if (d.Swim && d.Legs > 1 && d.Tails == 1)
                {
                    Console.WriteLine("\t{0}", getName(d));
                }
            }
        }

        public static void DjurSomKanSimmaOchFlyga(List<Djur> djur)
        {
            Console.WriteLine("\nDjur som kan simma och flyga.");
            foreach (Djur d in djur)
            {
                if (d.Swim && d.Fly)
                {
                    Console.WriteLine("\t{0}", getName(d));
                }
            }
        }

        public static void Main(string[] args)
        {
            List<Djur> djur = new List<Djur>();

            // constructor for class( bool tame, int legs, int tails, bool fly, bool walk, bool swim){

            djur.Add(new Haj(true, 3, 2, false, true, true));
            djur.Add(new Människa(false, 3, 1, true, false, false));
            djur.Add(new Katt(true, 3, 1, true, false, false));
            djur.Add(new Hund(true, 2, 1, true, true, true));
            djur.Add(new Lejon(false, 0, 1, true, false, false));
            djur.Add(new Anka(false, 0, 1, true, false, true));
            djur.Add(new Varg(false, 1, 1, true, false, false));
            djur.Add(new Boaorm(false, 0, 1, true, true, true));
            djur.Add(new Fisk(false, 10, 0, true, false, false));


            DjurSomKanSimma(djur);
            DjurSomKanSimmaOchHarFlerBenÄnEttOchEnSvans(djur);
            DjurSomKanSimmaOchFlyga(djur);
        }
    }
}
