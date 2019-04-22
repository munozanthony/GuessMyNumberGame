using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPlay
{
    class Program
    {
        //Average guesses
        //1: 12
        //2: 12
        //3: 11
        //4: 8
        //5: 9
        static void Main(string[] args)
        {
            int winningNumber = NumRange(1, 1000);
            int count = 0;
            int humanGuess = 0;

            do
            {
                humanGuess = HumanGuess();
                if (humanGuess < winningNumber)
                {
                    Console.WriteLine("Hahaha...Guess higher human!!!");
                    ++count;
                }
                else  
                {
                    Console.WriteLine("Guess lower human!!!\nAI will surpass you soon...");
                    ++count;
                }               
            } while (humanGuess != winningNumber);
            Console.WriteLine(
                $"It is about time human!!! The number was {winningNumber}\n It took you a lot of tries...specifically {count} times!!!");
        }

        static int NumRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static int HumanGuess()
        {
            int guess = 0;

            do
            {
                Console.WriteLine("Choose a number 1-1000:");
                Console.WriteLine();
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Make a valid selection 1-1000");
                }
            } while (guess < 1 || guess > 1000);

            return guess;
        }
      
    }
}
