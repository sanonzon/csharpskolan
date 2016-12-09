/*        public void insertIntoDatabase(string table, string[] words){
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            string temp = "";
            int counter = 0;
            for(int i = 0; i < words.Length; i++){                
                if(temp.Length > 0) {
                    temp += ", (NULL,'"+words[i]+"')";
                    counter++;                    
                }
                else{
                    temp += "(NULL,'"+words[i]+"')";
                    counter++;
                }
                if (counter > 500){
                    string query = "INSERT INTO csharpleken."+table+" (id, word) values "+temp+";";
                    System.Console.WriteLine(query);
                    temp ="";
                    try{
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(query, conn);
                        try {
                            command.ExecuteNonQuery();
                        }catch(MySqlException e) {
                            System.Console.WriteLine(e.StackTrace);
                        }
                    }
                    catch(MySqlException e){
                        System.Console.WriteLine(e.StackTrace);
                    }
                    finally{
                        conn.Close();
                    }
                    counter = 0;
                }
            }
            
            

           System.Console.WriteLine("Done."); 
        }*/