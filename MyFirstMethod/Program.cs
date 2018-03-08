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
            // Valor escrito pelo utilizador que define o limite da contagem
            string s;
            // Valor convertido do limite da contagem
            int nCount;

            Console.Write("Ate' que valor queres na 1º contagem? ");
            s = Console.ReadLine();
            nCount = Convert.ToInt32(s);
            Console.WriteLine("\n1º Contagem\n-------");
            CountToN(nCount);
            Console.WriteLine("-------");

            Console.Write("Ate' que valor queres na 2º contagem? ");
            s = Console.ReadLine();
            nCount = Convert.ToInt32(s);
            Console.WriteLine("\n2º Contagem\n-------");
            CountToN(nCount);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
