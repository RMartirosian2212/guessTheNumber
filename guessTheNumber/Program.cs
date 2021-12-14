using System;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey symbol = ConsoleKey.Y;
            while(symbol == ConsoleKey.Y)
            {
                Generate number = new Generate();
                Game game = new Game(number.GetNumber());


                Console.WriteLine(number.GetNumber());

                int userInput = int.MinValue;
                Output result = game.Check(userInput);

                while (result.IsOver() != true)
                {
                    userInput = int.Parse(Console.ReadLine());
                    result = game.Check(userInput);
                    Console.WriteLine(result.Message());
                }

                Console.WriteLine("Start a new game? (y/n)");
                symbol = Console.ReadKey().Key;
                Console.WriteLine();
            }
        }
    }
}
