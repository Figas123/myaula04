using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04
{
    class MyClass
    {
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1º Contagem\n-------");
            CountTo10();
            Console.WriteLine("-------");
            Console.ReadKey();
            Console.WriteLine("2º Contagem\n-------");
            CountTo10();
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
