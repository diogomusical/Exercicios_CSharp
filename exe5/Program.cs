using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, total_numero = 0.0, nr_numeros = 0.0;

            do
            {
                Console.WriteLine("Introduza o " + $"{nr_numeros+1}" + "º número positivo: ");
                numero = double.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    total_numero += numero;
                    nr_numeros += 1.0;
                }
            } while (numero >= 0);
            Console.WriteLine("MEDIA: " + $"{total_numero/nr_numeros}");
        }
    }
}
