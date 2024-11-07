using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exe14
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int valor;
            int nr_valores_pos = 0, nr_valores_neg = 0;
            double total_valores = 0.0;
            int nr_valores;

            Console.WriteLine("Introduza o número de valores que pretende introduzir:");
            nr_valores = int.Parse(Console.ReadLine());

            for (int i = 0; i < nr_valores; i++)
            {
                Console.WriteLine("Introduza o " + $"{i + 1}" + "º número:");
                valor = int.Parse(Console.ReadLine());

                if(valor >= 0)
                {
                    nr_valores_pos++;
                }
                else
                {
                    nr_valores_neg++;
                }
                total_valores += valor;
            }

            Console.WriteLine("Número de valores positivos: " + $"{nr_valores_pos}");
            Console.WriteLine("Número de valores negativos: " + $"{nr_valores_neg}");
            Console.WriteLine("Percentagem de valores negativos: " + $"{nr_valores_neg*100/nr_valores}");
            Console.WriteLine("Percentagem de valores positivos: " + $"{nr_valores_pos * 100 / nr_valores}");

            Console.WriteLine("MÉDIA: " + $"{ total_valores / (nr_valores)}");


        }
    }
}
