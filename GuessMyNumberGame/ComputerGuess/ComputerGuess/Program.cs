using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGuess
{
    class Program
    {
        static void Main(string[] args)
        {   //Computer guess results for 5 iterations
            //1. 7
            //2. 7
            //3. 7
            //4. 7
            //5. 6
            int min = 1;
            int max = 100;
            int count = 1;
            int choice = 0;
            int compGuess;
            int winner = EnterWinningNumber();

            do
            {
                compGuess = ComputerGuess(min, max);
                Console.WriteLine($"Machine guesses {compGuess}...is this correct?");
                Console.WriteLine("1: Correct Number | 2: It's Lower | 3: It's Higher");
                winner = Convert.ToInt32(Console.ReadLine());

                if (winner == 1)
                {
                    Console.WriteLine($"The machine guessed in {count} turns");
                }

                else if (winner == 2)
                {
                    max = compGuess;
                    count++;
                }

                else
                {
                    min = compGuess;
                    ++count;
                }
            } while (compGuess != winner);

            Console.WriteLine($"The machine guessed the correct number in {count} turns");
            
        }

        static int ComputerGuess(int min, int max)
        {
            int compGuess = min + ((max - min) / 2);
            return compGuess;
        }

        static int EnterWinningNumber()
        {
            int winningNumber = 0;

            do
            {
                Console.WriteLine("Enter the a number 1-100...\nLet's see how many tries it takes a machine!!!");
                try
                {
                    winningNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number between 1-100");
                }
            } while (winningNumber < 1 || winningNumber > 100);

            return winningNumber;
        }
    }
}
