using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            NRtLC convert = new NRtLC();

            //variables for input validation
            int min = 1;
            int max = 0;
            string response;

            // User input
            while (min > max)
            {
                do
                {
                    Console.Write("min: ");
                    response = Console.ReadLine();

                } while (int.TryParse(response, out min) == false);

                do
                {
                    Console.Write("max: ");
                    response = Console.ReadLine();

                } while (int.TryParse(response, out max) == false);

                if (min > max)
                {
                    Console.WriteLine("Your min is larger than your max!");
                }
            }


            // Gather user input un validated
          /*  Console.Write("min: ");
            int userMin = int.Parse(Console.ReadLine());

            Console.Write("max: ");
            int userMax = int.Parse(Console.ReadLine());
            */

            convert.Compute(min, max); // compute the NRtLC

            Console.ReadKey();

        }

    }
}
