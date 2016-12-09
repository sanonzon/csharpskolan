using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace HangmanSpace{
    public class InsertWords{
        private Regex rgx = new Regex(@"^[a-zA-Z]+$");
        public bool testWord(string s) {
            if(rgx.IsMatch(s,0)){
                return true;
            }
            
            return false;
        }
        
        public string[] readFile(){            
            string[] lines = System.IO.File.ReadAllLines(@"/home/suddan/text.txt");

            return lines;

        }
    }
}