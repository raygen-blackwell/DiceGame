using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for the "rollNumber" which is the number of times the dice will be rolled
            Console.Write("How many times would you like to roll the dice? ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            //Roll dice using random and keep track of each total
            Random rnd = new Random();
            int[] rollResults = new int[13];
            for (int i = 0; i < rollNumber; i++)
            {
                int dice1 = (rnd.Next(6));
                int dice2 = (rnd.Next(6));
                rollResults[dice1 + dice2]++;
            }

            //Calculate percent for the result number when dice were "thrown"
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)rollResults[i] / rollNumber * 100;

                // Print the histogram
                Console.Write($"{i}: ");
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
