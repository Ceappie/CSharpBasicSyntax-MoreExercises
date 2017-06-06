using System;


namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            var game = Console.ReadLine();
            double price = 0;
            double totalSpent = currentBalance;
            var currentGame = string.Empty;

            while (!(game == "Game Time"))
            {
                currentGame = game;
                if (game == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    game = Console.ReadLine();
                    continue;
                }
                if (price <= currentBalance)
                {
                    currentBalance -= price;
                    Console.WriteLine($"Bought {currentGame}");
                }
                else if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");

                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            totalSpent -= currentBalance;
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
