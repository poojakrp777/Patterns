using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class StarPattern
    {
        public static void PrintStarPattern()
        {
            Console.WriteLine("Enetr the number of Star to print: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
   

}
