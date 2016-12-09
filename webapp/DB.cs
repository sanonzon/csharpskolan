using System;
using MySql.Data.MySqlClient;



namespace WebApp{
    public class DB{
       // private string ip, port, ssl, login, passwd, database;
        private string ConnectionString;
        
        public DB(String ip, String port, String ssl,String login, String  passwd, String database){
            ConnectionString = string.Format("server={0};port={1};SslMode={2};uid={3};pwd={4};database={5};",ip,port,ssl,login,passwd,database);
        }
        public String getConnection(){
            return ConnectionString;
        }

        public void CreateUser(string email, string password){
            using(MySqlConnection conn = new MySqlConnection(this.ConnectionString)) {
                string s = "INSERT into user (email,password) VALUES (@email,@password)";
                using(MySqlCommand query = new MySqlCommand(s)){
                    query.CommandTimeout = 20;
                    query.Connection=conn;
                    query.Parameters.AddWithValue("@email",email);
                    query.Parameters.AddWithValue("@password",password);
                    conn.Open();
                    query.ExecuteNonQuery();
                }
            }
        }
        public int Login(string email, string password){
            using(MySqlConnection conn = new MySqlConnection(this.ConnectionString)) {
                
                string s = "SELECT * FROM user WHERE email=@email AND password=@password";
                using(MySqlCommand query = new MySqlCommand(s)){
                    query.CommandTimeout = 20;
                    query.Connection=conn;
                    query.Parameters.AddWithValue("@email",email);
                    query.Parameters.AddWithValue("@password",password);
                    conn.Open();
                    query.ExecuteNonQuery();

                    DataSet ds = new DataSet();
                    MySqlDa
                }
            }
        }
        
    }

}
