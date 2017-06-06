using System;


namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int fotoName = int.Parse(Console.ReadLine());
            int fotoDay = int.Parse(Console.ReadLine());
            int fotoMonth = int.Parse(Console.ReadLine());
            int fotoYear = int.Parse(Console.ReadLine());
            int fotoHours = int.Parse(Console.ReadLine());
            int fotoMinutes = int.Parse(Console.ReadLine());
            double fotoSize = double.Parse(Console.ReadLine());
            int fotowidth = int.Parse(Console.ReadLine());
            int fotohight = int.Parse(Console.ReadLine());

            double size = 0;
            var type = string.Empty;
            var resolution = string.Empty;

            Console.WriteLine($"Name: DSC_{fotoName:d4}.jpg");
            Console.WriteLine($"Date Taken: {fotoDay:d2}/{fotoMonth:d2}/{fotoYear} {fotoHours:d2}:{fotoMinutes:d2}");

            if (fotoSize < 1000)
            {
                size = fotoSize;
                type = "B";
            }
            else if (fotoSize < 1000000)
            {
                size = fotoSize / 1000;
                type = "KB";
            }
            else
            {
                size = fotoSize / 1000000;
                type = "MB";
            }
            Console.WriteLine($"Size: {size}{type}");

            if (fotowidth > fotohight)
            {
                resolution = "(landscape)";
            }
            else if (fotohight > fotowidth)
            {
                resolution = "(portrait)";
            }
            else
            {
                resolution = "(square)";
            }
            Console.WriteLine($"Resolution: {fotowidth}x{fotohight} {resolution}");
        }
    }
}
