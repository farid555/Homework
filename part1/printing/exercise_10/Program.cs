using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            
            Console.WriteLine("Give a name for main Character:");
            string charaName = Console.ReadLine();
            Console.WriteLine("Give the charater a profession:");
            string chara_profession = Console.ReadLine();
            Console.WriteLine("Here is the story:" + "\n" + "Once upon a time there was a " 
            + chara_profession + " called " + charaName + "\n" + "On her way to work, " 
            + charaName + " often pondered what being " + chara_profession + " meant to them."
            + "\n" + "When you work as a " + chara_profession + " you meet interesting people."
            + "\n" + charaName + " enjoy their work as " + chara_profession + "," + " The end.");  
        }
    }
}
