using System;
using System.Collections.Generic;

namespace HangmanSpace{

    
    public class Hangman{
        public Hangman(){
            this.guesses = 10;
        }
        private string word;
        private int guesses;
        private bool won = false;
        public List<char> correctLetters = new List<char>();
        
        public void setWon(bool b){
            this.won = b;
        }
        public void setWord(string s){
            this.word = s;
        }

        public bool getWon(){
            return this.won;
        }
        public string getWord(){
            return this.word;
        }
        public int getGuesses(){
            return this.guesses;
        }
        public void testInput(String s){
            if (s.Length > 1){
                if (s.Equals(word)){
                    Console.WriteLine("Correct!");
                    this.won = true;
                }
                else{
                    Console.WriteLine("Wrong!");            
                    this.guesses -= 1;                
                }
            }
            else if(s.Length == 1 && this.word.Contains(s)) {
                if(correctLetters.Contains(s[0])){
                    Console.WriteLine("You have already guessed that letter.");
                    this.guesses -= 1;
                }
                else {
                    correctLetters.Add(s[0]);
                }
            }
            else{
                Console.WriteLine("Wrong!");            
                this.guesses -= 1;                
            }
        }
        
        public string getWordWithGuesses() {
            String s = "";
            for(int i = 0; i < this.word.Length; i++) {
                if (correctLetters.Contains(this.word[i])){
                    s += " " + this.word[i];
                }
                else {
                    s += " _";
                }
            }
            
            
            return s.Trim();
        }
        public bool languageTest(String s){
            if(s.Equals("english") || s.Equals("swedish")){
                return true;
            }

            return false;
        }
        public static void Main(string[] args){
            Hangman program = new Hangman();            
            DB db = new DB();
        
            
            Console.WriteLine("Choose language of word. English or Swedish."); 
            String language = "";
            
            while(!program.languageTest((language = Console.ReadLine().ToLower()))) {
                 Console.WriteLine("Incorrect choice... English or Swedish.");                
            }
            
            
            
            string word = db.getSomething(language);
            
            if (word != null && !word.Equals("")){
                program.setWord(word.ToUpper());
            }
            else {
                Console.WriteLine("Could not fetch word from DB. Aborting...");
                Environment.Exit(1);
            }
            
            
            while(program.guesses > 0) {
                Console.WriteLine("Guess a letter or the whole word. Faulty guesses left: " + 
                    program.getGuesses() + "\n");                
                String input = Console.ReadLine();
                program.testInput(input.ToUpper());
                
                if (program.getWord().Equals(program.getWordWithGuesses().Replace(" ","")) || program.getWon()){
                    program.setWon(true);
                    Console.WriteLine("Congrats, you won.");                    
                    break;
                }
                else {
                    Console.WriteLine(program.getWordWithGuesses());
                }
            }
            // Failed to guess.
            if (!program.getWon()){
            Console.WriteLine("You lost.");    
            }
            Console.WriteLine("The correct word was: " + program.getWord());
        }
    }
}
