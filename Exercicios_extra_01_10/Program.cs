using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_extra_01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr_negativos = 0;
            double numero;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduza  o Nº"+ $"{i}" + ":");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    nr_negativos++;
                }
            }

            Console.WriteLine("Número total de valores negativos: " + nr_negativos);
        }
    }
}
