using System;
using System.Threading;

namespace Animacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorfulAnimation();
        }

        static void ColorfulAnimation()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    Console.Clear();

                    // steam
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("     . . . . o o o o o o");
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o");
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);

                    Console.WriteLine(margin + "              _____      o"); Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(margin + "     ____====  ]OO|_n_n__][.");
                    Console.WriteLine(margin + "    [________]_|__|________)< ");
                    Console.WriteLine(margin + "     oo    oo  'oo OOOO-| oo\\_"); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");

                    Thread.Sleep(100);
                }
            }
        }
    }
}
