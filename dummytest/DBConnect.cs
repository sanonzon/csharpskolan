using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HangmanSpace{
    public class DB{
        private string connectionString = "server=stoutserver.dyndns.org;" +
        "uid=csharpleken;" +
        "pwd=csharpleken;" +
        "database=csharpleken;" +
        "SslMode=None;" + 
        "Port=3306;";

        public string getSomething(string language) {
            MySqlConnection conn = new MySqlConnection(this.connectionString);    
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM csharpleken."+language+"words ORDER BY RAND() LIMIT 1;", conn);
            
            string fetched = null;
            try {
                using (MySqlDataReader reader = command.ExecuteReader()){     
                    while(reader.Read()){
                        fetched = $"{reader["word"]}";                    
                        break;
                    }                           
                }
            }catch(MySqlException e){
                System.Console.WriteLine(e.StackTrace);
            }
            
            
            
            conn.Close();
            return (fetched != null) ? fetched : "";
        }
    }
}