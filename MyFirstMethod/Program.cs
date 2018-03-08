using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04
{
    class MyClass
    {
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ate' que valor queres contar?");
            string s = Console.ReadLine();
            int nCount = Convert.ToInt32(s);
            Console.WriteLine("\n1º Contagem\n-------");
            CountToN(nCount);
            Console.WriteLine("-------");
            Console.ReadKey();
            Console.WriteLine("2º Contagem\n-------");
            CountToN(nCount);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
