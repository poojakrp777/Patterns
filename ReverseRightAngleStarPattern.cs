using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class ReverseRightAngleStarPattern
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enetr the number of Star to print: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++) //rows
            {
                for (int j = number; j >= i; j--) //colums
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
