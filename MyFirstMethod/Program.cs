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
        /// Meant to count incresingly from 0 to 10
        /// </summary>
        static void CountTo10()
        {
            for(int i= 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
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
        /// Meant to count incresingly between the numbers n1 and n2, inclusivly
        /// </summary>
        /// <param name="n1">Starts counting here</param>
        /// <param name="n2">Stops counting here</param>
        static void CountToN(int n1, int n2)
        {
            for(int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// The body of the program, where the program starts and ends.
        /// </summary>
        /// <param name="args">Arguments used</param>
        static void Main(string[] args)
        {
            string s;
            int n1, n2;

            Console.Write("Qual o valor em que queres comecar a contagem? ");
            s = Console.ReadLine();
            n1 = Convert.ToInt32(s);
            Console.Write("Qual o valor em que queres parar de contagem? ");
            s = Console.ReadLine();
            n2 = Convert.ToInt32(s);
            Console.WriteLine("\nContagem\n-------");
            CountToN(n1, n2);
            Console.WriteLine("-------");
            Console.ReadKey();
        }
    }
}
