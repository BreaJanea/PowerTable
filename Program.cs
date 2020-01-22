using System;

namespace Powers
{
    class Program
    {
        static void Main(string[] args)
        {

            string userContinue;
            int square;
            int cubed;

            Console.WriteLine("Learn your sqaures and cubes!");
            do
            {
               Console.Write("Enter an integer: ");
               int input = int.Parse(Console.ReadLine());

                Console.WriteLine($"Number\tSquare\tCubed");
                Console.WriteLine($"===\t===\t===");
                for (int i = 1; i <= input; i++)
                {
                    square = i * i;
                    cubed = i * i * i;
                    Console.WriteLine($"{i}\t{square} \t{cubed}");
                }
                Console.WriteLine();
              
                Console.WriteLine("Continue (y/n) ");
                userContinue = Console.ReadLine();

            } while (userContinue.ToLower() == "y");
            {
                Console.WriteLine("See ya!");
            }
        }
    }
}


