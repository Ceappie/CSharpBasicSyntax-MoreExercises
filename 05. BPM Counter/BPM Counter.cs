using System;


namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal beatsPerMinutes = decimal.Parse(Console.ReadLine());
            decimal beatsNumber = decimal.Parse(Console.ReadLine());

            decimal totalSeconds = (60 / beatsPerMinutes * beatsNumber);

            int minutes = (int)totalSeconds / 60;
            int seconds = (int)totalSeconds % 60;

            decimal bars = beatsNumber / 4;

            
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
