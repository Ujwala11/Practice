using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code2
{
    class Range
    {
           public bool test(int c, int d)
            {
                return ((c >= 40 || c <= 50) && (d >= 40 || d <= 50) ||  (c >= 50 || c <= 60) && (d >= 50 || d <= 60));
               
            }
        
    }
}
