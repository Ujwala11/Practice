using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code2
{
    class Multiple
    {
        public void Multiples()
        {
            //multiple of 3 or 7
            string a;
            Console.WriteLine("enetr a number");
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            if (b % 3 == 0 && b % 7 == 0)
            {
                Console.WriteLine("Multiple of 3 and 7");
                Console.ReadLine();
            }
            else if (b % 3 == 0)
            {
                Console.WriteLine("Multiple of 3");
                Console.ReadLine();
            }
            else if (b % 7 == 0)
            {
                Console.WriteLine("Multiple of 7");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a multiple of 3 or 7");
                Console.ReadLine();
            }
        }
    }
}
