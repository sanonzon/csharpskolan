using System;

namespace WebApp
{
    public class User{
        int userId;
        

    }


    public class ConsoleStuff{
        private DB mysql = new DB("192.168.0.103","3306","None","csharpleken","csharpleken","csharpleken");
        private Validation validation = new Validation();
        
        int choice;
        string email, password;

        public void ConsoleMenu(){
            Console.WriteLine("1 - Register new User");
            Console.WriteLine("2 - Login");

            ConsoleChoice();
        }
        public void ConsoleChoice(){
            String s = Console.ReadLine();
            if(int.TryParse(s, out choice)){
                switch(choice){
                    case 1:
                        ConsoleRegister();
                        break;
                    case 2:
                        ConsoleLogin();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }

        public void ConsoleLogin(){
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            
            Console.Write("Enter password: ");
            password = Console.ReadLine();
            
            choice = mysql.Login(email,password);

        }
        public void ConsoleRegister(){
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            if(validation.ValidateEmail(email) ) {
                mysql.CreateUser(email,password);
            }
            
        }
    }

    public class Program
    {    
        private static string email,password;
        private static int parkspaceNum, apartmentNum;
        
        
        public static void Main(){
            DB mysql = new DB("192.168.0.103","3306","None","csharpleken","csharpleken","csharpleken");
            Validation validation = new Validation();
            Security secdoot = new Security();
            ConsoleStuff c = new ConsoleStuff();


            c.ConsoleMenu();

            
            
            
                       

            
          /*
            Console.Write("Text to hash: ");
            input = Console.ReadLine();
            Console.WriteLine("hashed: {0}",secdoot.HashThatShit(input));
            */
        }
    }
}
