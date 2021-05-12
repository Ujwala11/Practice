using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code1
{
    class Class1
    {
        /* int a = 0;
         int b = 0;
         public void Hint()
         {
             Console.WriteLine(" the hint is your name");
             Console.ReadLine();
             return;
         }

         public int Value(int a)
         {
             Console.WriteLine("the value of the integer is " + a);
             Console.ReadLine();
             return a;
         }

         public void SetValues(int a, int b)
         {
             this.a = a;
             this.b = b;
         }

        public void PrintValues()
         {
             Console.WriteLine("the value of int a is " + a);
             Console.WriteLine("the value of int b is " + b);
             Console.ReadLine();

         }*/

        public string color;

        public override bool Equals(object obj)
        {
            var y = (Class1)obj;
            if (this.color == y.color)
            {
                return true;
            }
            return false;
        }
    }
}
