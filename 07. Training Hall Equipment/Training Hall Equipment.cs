using System;


namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemToBuy = int.Parse(Console.ReadLine());

            double subTotal = 0;
            double moneyLeft = 0;

            for (int item = 0; item < itemToBuy; item++)
            {
                var itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    itemName = itemName + "s";
                }

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                subTotal += itemPrice * itemCount;
            }
            moneyLeft = budget - subTotal;

            Console.WriteLine($"Subtotal: ${subTotal:f2}");

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):f2} more.");
            }
        }
    }
}
