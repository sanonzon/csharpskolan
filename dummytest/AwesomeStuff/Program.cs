using System;

namespace ConsoleApplication
{
    public class Program
    {
        public void print(){
            Console.WriteLine(this.name + " is " + this.age + " years old.");
        }
        Program(String s, int i){
            this.name=s;
            this.age=i;
        }
        Program(){
            this.name="";
            this.age=0;
        }
        public void setName(String s) {
            this.name=s;
        }
        public void setAge(int i) {
            this.age = i;
        }
        private string name;
        private int age;
        /*public static void Main(string[] args)
        {
            Program kalle = new Program("Kalle",23);
            Program bengt = new Program();
            bengt.setAge(99);
            bengt.setName("Bengt");
            bengt.print();
            kalle.print();
            
            //Console.WriteLine("Hello World! akjdsakjdsak");
        }*/
    }
}
