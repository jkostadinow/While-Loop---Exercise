using System;
using System.Transactions;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chageToReturn = double.Parse(Console.ReadLine()) * 100;
            int count = 0;
            while (chageToReturn > 0)
            {
                if (chageToReturn >= 200)
                {
                    chageToReturn -= 200;
                    count++;
                }
                else if (chageToReturn >= 100)
                {
                    chageToReturn -= 100;
                    count++;
                }
                else if (chageToReturn >= 50)
                {
                    chageToReturn -= 50;
                    count++;
                }
                else if (chageToReturn >= 20)
                {
                    chageToReturn -= 20;
                    count++;
                }
                else if (chageToReturn >= 10)
                {
                    chageToReturn -= 10;
                    count++;
                }
                else if (chageToReturn >= 5)
                {
                    chageToReturn -= 5;
                    count++;
                }
                else if (chageToReturn >= 2)
                {
                    chageToReturn -= 2;
                    count++;
                }
                else if (chageToReturn >= 1)
                {
                    chageToReturn -= 1;
                    count++;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(count);
        }
    }
}