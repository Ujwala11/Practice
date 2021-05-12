using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code3
{
    class Primenos
    {
        public void Prime()
        {

            int length = 20000 ;
            for (int i = 2; i < length; i++)
            {
                int t = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        t++;

                    }
                }
                if (t == 2)
                {
                        Console.WriteLine(i + " is a prime number");
                        //Console.ReadLine();
                }
                
                
               
            }
        }
    }
}
