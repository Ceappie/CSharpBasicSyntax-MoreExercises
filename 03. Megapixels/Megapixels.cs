using System;


namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            decimal pixels = width * height;
            decimal megapixels = pixels / 1000000;

            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(megapixels, 1));
        }
    }
}
