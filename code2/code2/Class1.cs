using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code2
{
    class Person1
    {
        public string name;
        public int age;

        public Person1(int _age, string _name)
        {
            this.age = _age;
            this.name = _name;
        }
        public void Printval()
        {
            Console.WriteLine("age is:"+age + "name is :" +name);
            Console.ReadLine();
        }
    }
}
