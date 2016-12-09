//using System.Security.Cryptography;


namespace WebApp{
    public class Security{
        public byte[] GetBytes(string s){
            byte[] bytes = new byte[s.Length * sizeof(char)];
            System.Buffer.BlockCopy(s.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public string HashThatShit(string s){
     /*       using (var algo = new SHA256Managed ()) {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);
                byte[] hashedBytes = algo.ComputeHash(bytes);
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                    foreach (byte b in hashedBytes) {
                        builder.Append(b.ToString("x2"));
                    }

                    // Return it to the caller, to write it.
                return builder.ToString();
                }


                */
            return s;   
            /*System.Security.Cryptography.SHA256 hash = new System.Security.Cryptography.SHA256Managed.Create();
            byte[] temp = GetBytes(s);            
            byte[] b = hash.ComputeHash(temp);

            return b;
            */
        }
    }
}
