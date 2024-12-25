using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int flatSize = w * l * h;

            string input = Console.ReadLine();
            int numBox;

            while (input != "Done")
            {
                numBox = int.Parse(input);
                if (numBox > flatSize)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(numBox - flatSize)} Cubic meters more.");
                    flatSize -= numBox;
                    break;
                }
                flatSize -= numBox;
                input = Console.ReadLine();
            }
            if (flatSize > 0)
            {
                Console.WriteLine($"{flatSize} Cubic meters left.");
            }


        }
    }
}
