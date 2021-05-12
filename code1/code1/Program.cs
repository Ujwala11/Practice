using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static code1.Class1;

namespace code1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double a = 10.32;
             int b = 98;
             string c = Convert.ToString(a);
             string c1 = Convert.ToString(b);

             string c2 = "934";
             int d = Convert.ToInt32(c2);

             Console.WriteLine("the value of c is " + c);
             Console.WriteLine("the data type of c is" + c.GetType());

             Console.WriteLine("the value of d is " + d);
             Console.WriteLine("the data type of d is" + d.GetType());
             Console.ReadLine();

            Class1 c = new Class1();
            c.Hint();

            Class1 d = new Class1();
            d.Value(10);

            Class1 f = new Class1();
            f.SetValues(23,56);
            f.PrintValues();*/

            Class1 x = new Class1();
            x.color = "red";

            Class1 y = new Class1();
            y.color = "rain";

            if (x.Equals(y))
            {
                Console.WriteLine("colors are the same");
                Console.ReadLine();
            }
            Console.WriteLine("colors are not same");
            Console.ReadLine();

      
            
           
        }
    }
}
