using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAula04
{
    class MyClass
    {
        /// <summary>
        /// Meant to count incresingly from 1 untill n.
        /// </summary>
        /// <param name="n">Number set by user, its the limit to count too.</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// The body of the program, where the program starts and ends.
        /// </summary>
        /// <param name="args">Argumentos used</param>
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
