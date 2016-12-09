using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class StringList{
        public List<int> list = new List<int>();
        public StringList() {
            
        }
        public StringList(List<int> li) {
            list = li;
        }

        public List<int> FromString(string s){
            List<int> li = new List<int>();
       
            s = s.Substring(1);
            s= s.Remove(s.LastIndexOf("]"));
            string[] sa = s.Split(',');
            foreach(string ss in sa){
                int i;
                if ((int.TryParse(ss,out i))){
                    li.Add(i);
                }
            }

            return li;
        }
        public override string ToString(){
            string s = "[";
            foreach(int i in list){
                s+= string.Format("{0},",i);
            }
            s=s.Remove(s.LastIndexOf(","));
            s+="]";
            return s;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> li = new List<int>{1,2,3};
            StringList sl = new StringList(li);
            StringList ssl = new StringList();

            Console.WriteLine("newly created list to string: {0}",sl.ToString());


            sl.FromString(sl.ToString());

            Console.WriteLine("old list to string to new list<int> to string: {0}",sl.FromString(sl.ToString()).ToString());

            List<int> doot = ssl.FromString("[1,2,3,4,5,6,7,8,9]");
            foreach(int d in doot){
                Console.Write("{0}\t",d);
            }
            Console.WriteLine();
            
            
        }
    }
}
