using System;
using System.Collections.Generic;

namespace ConsoleApplication{
    public class Program{
        public string ReadFromFile(string path){
            string s = "";
            if(System.IO.File.Exists(@path)){
              s = System.IO.File.ReadAllText(@path);
            }
            else{
                Console.WriteLine("File does not exist, be less shit.");
                System.Environment.Exit(-1);
            }
            return s;
        }
        public string[] StringToArray(string s) {            
            double d = 0;
             if(s.Contains(",")) {
                return s.Split(',');
             }
             else if (s.Contains(" ")){
                 return s.Split(' ');
             }            
             else if (double.TryParse(s,out d)){
                 return new string[]{s};
             }
             return null;
        }


        public List<double> StringToList(string s){
            List<double> li = new List<double>();    
            double d;

            // Remove standard [] when printing a whole array.
            if(s.StartsWith("[") && s.EndsWith("]")){
                s = s.Substring(1,s.Length-2);     
                Console.WriteLine("temp string: {0}",s);       
            }
            
            string[] stuff = StringToArray(s);

            if (stuff != null) {                
                foreach(string t in stuff){                                    
                    if(double.TryParse(t, out d)){                        
                        li.Add(d);
                    }
                }
            }
            else{
                Console.WriteLine("Chosen file must have numbers separated with either ',' or ' ' characters ");
                System.Environment.Exit(-1);
            }

            return li;
            


        }
        public void SaveToFile(string path, string text){        
            System.IO.File.WriteAllText(@path,text);
        }

        public string GetSeparator(string s){
            string separator = "";
            if(s.Contains(",")){
                separator = ",";                
            }
            else if (s.Contains(" ")){
                separator = " ";
            }
            return separator;
        }

        public static void Main(string[] args){
            Console.Write("args: ");
            foreach(string s in args){
                Console.Write("{0} ",s);
            }
            Console.WriteLine();

            string filename;
            if(args.Length > 0){
                filename = args[0];
            }
            else{
                Console.WriteLine("Enter path to filename: ");
                filename = Console.ReadLine();
            }



            Program p = new Program();
            string filecontent = p.ReadFromFile(filename);
            string separator = p.GetSeparator(filecontent);
            List<double> doot = p.StringToList(filecontent);

            Console.WriteLine("Array in order: ");
            foreach(double d in doot){
                Console.Write("{0} ",d.ToString());
            }
            
            Console.Write("Enter filename to save info: ");
            filename = Console.ReadLine();

            string text = "";
            foreach(double d in doot){
                text += string.Format("{0}{1}",d.ToString(),separator);
            }

            p.SaveToFile(filename, text); 





        }
    }
}
