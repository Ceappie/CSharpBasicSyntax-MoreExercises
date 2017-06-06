using System;


namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int characterNumbers = int.Parse(Console.ReadLine());
            var result = string.Empty;

            for (int cnt = 0; cnt < characterNumbers; cnt++)
            {
                var message = Console.ReadLine();
                int digit = int.Parse(message[0].ToString());
                int offset = (digit - 2) * 3;

                if (digit == 8 || digit == 9)
                {
                    offset += 1;
                }
                offset += message.Length - 1;

                if (digit == 0)
                {
                    result += " ";
                }

                else
                {
                    result += (char)(offset + 97);
                }
            }
            Console.WriteLine(result);
        }
    }
}
