// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;


namespace guessTheNumber
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Program program = new Program();
            program.guessTheNumber();
        }
        string test = "ehwhsshw";
        public void guessTheNumber()
        {
            //bool condition = true;
            //int i = 0;
            //while (condition)
            //{
            //    if(i < 8)
            //    {
            //        i++;
            //    var rand = new Random();
            //    var randomNumber = rand.Next(1, 8);
            //    Console.WriteLine(randomNumber);

            //    }
            //    else
            //    {
            //        condition = false;
            //    }
            //}
            var rand = new Random();
            var randomNumber = rand.Next(2, 100);
            Console.WriteLine("A number between 1 and 100 has been generated. Please note that a number between 1 and 100 means the same as a number from 2 to 99. Try to guess the generated number");
            bool condition = true;
            while (condition)
            {
                var guessNumber = Console.ReadLine();
                int convert = int.Parse(guessNumber);
                if (convert == randomNumber)
                {
                    Console.WriteLine("You guessed Correct");
                    condition = false;
                    Console.WriteLine("Do you want to play again? Type yes or no");
                    string playAgain = Console.ReadLine();
                    if(playAgain == "yes")
                    {
                        guessTheNumber();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("You guessed wrong");
                    if(convert < randomNumber)
                    {
                        Console.WriteLine("you guessed lower than the generated number, please try again");
                    }
                    else
                    {
                        Console.WriteLine("you guessed higher than the generated number, please try again");
                    }
                }
            }
        }

    }
}