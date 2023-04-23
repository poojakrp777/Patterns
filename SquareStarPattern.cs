using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class SquareStarPattern
    {
        public static void PrintSquareStarPattern()
        {
            Console.WriteLine("Enetr the number of Star to print: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if(j == 1 || j == number || i == 1 || i == number)
                    {
                        Console.Write("*  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
