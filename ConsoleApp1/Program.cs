using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette program undersøger bitmasker for EN oktet");
            Console.WriteLine("Først kan brugeren indtaste et tal ml 0 og 255, ");
            Console.WriteLine("som omregnes og udskrives i binær notation.");
            Console.WriteLine("Dernæst udskrives alle mulige bitmønstre for en enkelt oktet.");

            String talStr;
            byte bitMaskNumber;
            do
            {
                Console.Write("Indtast venligst et tal ml 0-255: ");
                talStr = Console.ReadLine();
            }
            while (!Byte.TryParse(talStr, out bitMaskNumber));

            Console.WriteLine("Bitmønstret er: {0}", Convert.ToString(bitMaskNumber, 2));


            talStr = "";
            bitMaskNumber = 0;
            for (int i = 0; i <= 8; i++)
            {
                talStr = talStr.PadRight(8, '0');
                talStr = talStr.Substring(0, 8);
               
                Console.Write($"Bitmønster: {talStr}, ");
                Console.Write("værdi {0}", Convert.ToByte(talStr, 2));
                Console.WriteLine();

                talStr = "1" + talStr; //set et et-tal foran

            }

        }
    }
}
