using System;


namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeDNA = int.Parse(Console.ReadLine());
            int Cnt = 0;

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
                {
                    for (int thirthLetter = 1; thirthLetter <= 4; thirthLetter++)
                    {
                        var sequence = $"{firstLetter}{secondLetter}{thirthLetter}";
                        sequence = sequence.Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T");

                        if (firstLetter + secondLetter + thirthLetter >= rangeDNA)
                        {
                            Console.Write($"O{sequence}O ");
                        }
                        else
                        {
                            Console.Write($"X{sequence}X ");
                        }

                        Cnt++;
                        if (Cnt % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
