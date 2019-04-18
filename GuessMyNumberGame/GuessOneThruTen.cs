using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class GuessOneThruTen
    {
        static int NumberRange(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public void GuessNumber()
        {
            int randomNum = NumberRange(1, 10);
            int count = 0;
            int input = 0;

            Console.WriteLine("I want to play a game...\nGuess a number 1-10:");
            while (input != randomNum)
            {
                try
                {
                input = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("I am losing my patience...pick a correct number");
                   
                }

                if (input < randomNum)
                {
                    Console.WriteLine("Think higher");
                    ++count;
                }
                else if (input > randomNum)
                {
                    Console.WriteLine("Think lower");
                    ++count;
                }
                else
                {
                    Console.WriteLine($"Finally!!! The number was {randomNum}\n It only took {count} times to guess....(sigh)");
                }
            }
        }
    }
}
