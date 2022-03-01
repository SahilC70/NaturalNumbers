using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Display n terms of natural number and their sum:\n");
            Console.Write("Input Value of terms : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.WriteLine("\nThe Sum of Natural Number upto {0} terms : {1}", n, sum);
            Console.ReadLine();
        }
    }
}
