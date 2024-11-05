using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double fact = 1, total = 2;

            Console.WriteLine("Introduza um número inteiro:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero; i++) {
                fact *= (i + 1);
                total += 1/fact;
            }

            Console.WriteLine("E: " + $"{total}");
        }
    }
}
