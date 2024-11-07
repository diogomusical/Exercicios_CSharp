using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extra_11_ate_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio, razao , nr, total;

            Console.WriteLine("Introduza o número em que inicia a progressão aritmética :");
            inicio =  int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza a razão: ");
            razao = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o número de termos: ");
            nr = int.Parse(Console.ReadLine());

            Console.WriteLine("1º termo: " + $"{inicio}");
            total = inicio;


            for (int i = 1; i < nr; i++)
            {
                Console.WriteLine($"{i + 1}" + "º termo: " + $"{razao * i}");
                total += razao*i;
            }

            Console.WriteLine("Total da soma dos termos: " + $"{total}");

        }
    }
}
