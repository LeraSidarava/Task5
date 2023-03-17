using System;

namespace ConsoleApplicationSecondMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by a space:");

            string input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            //Declare max and seconMax values

            int max = int.MinValue;
            int secondMax = int.MinValue;

            //Find secondMax value by 


            foreach (int number in numbers)
            {
                if (number > max)
                {
                    secondMax = max;
                    max = number;
                }

                else if (number > secondMax && number < max)
                {
                    secondMax = number;
                }
            }




            Console.WriteLine("The second maximum value is: " + secondMax);

            Console.ReadLine();
        }
    }
}