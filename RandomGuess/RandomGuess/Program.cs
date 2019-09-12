//Brock Wright
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASS SOLUTION.
            Random rand = new Random();
            Console.WriteLine("Please enter the minimum for your random number. >>");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum for your random number. >>");
            int max = Convert.ToInt32(Console.ReadLine());

            //If the loop starts here, we will generate a new random number every time.
            int generatednumber = rand.Next(min, max + 1);

            Console.WriteLine(generatednumber);
            int ans = 0;
            while (ans != generatednumber)
            {
                Console.WriteLine($"Please guess a number between {min} and {max}. >>");
                string answer = Console.ReadLine();
                if(Int32.TryParse(answer, out ans) == false)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }

                ans = Convert.ToInt32(answer);

                if (ans == generatednumber)
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                }
                else
                {
                    Console.WriteLine("Sorry, try again.");
                }
            }
            

            Console.ReadKey();
            //My Solution:
            //Random rand = new Random();
            //int roll = rand.Next(1, 100);
            //Start:
            //Console.WriteLine("Please guess a number between 1 and 100. >>");
            //string answerAsString = Console.ReadLine();
            //int answer = Convert.ToInt32(answerAsString);
            


            //if (roll == answer)
            //{
            //    Console.WriteLine("Congratulations! You correctly guessed the right number!");
            //}
            //else
            //{
            //    Console.WriteLine("You did not guess correctly.");
            //    goto Start;
            //}

            //Console.ReadKey();
        }
    }
}
