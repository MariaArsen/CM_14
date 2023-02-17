using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Джулия");
            {
                cat.ShowInfo();
            }
            Dog dog = new Dog("Бонд");
            { 
                dog.ShowInfo();
            }
            Console.ReadKey();
        }
    }
}
