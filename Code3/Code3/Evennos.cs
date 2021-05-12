using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code3
{
    class Evennos
    {
        public void Even()
        {
            int length = 20000;
            for (int i = 1; i < length; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                   // Console.ReadLine();
                }
              
            }
        }
    }
}
