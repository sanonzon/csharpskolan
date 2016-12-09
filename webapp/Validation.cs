using System;
using System.Text;
using System.Text.RegularExpressions;

namespace  WebApp{
    public class Validation{
        public bool ValidateEmail(String s) {
            Regex re = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            
            
            Console.WriteLine("Checking '{0}' if valid email : {1}",s,re.IsMatch(s));
            return re.IsMatch(s);

        }
    }    
}