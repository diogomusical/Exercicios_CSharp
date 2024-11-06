using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr = 50;
            double[] numeros = new double[nr];
            double maior, menor;

            Console.WriteLine("Introduza o 1º número: ");
            numeros[0] = double.Parse(Console.ReadLine());
            maior = numeros[0];
            menor = numeros[0];

            for (int i = 1; i < nr; i++)
            {
                Console.WriteLine("Introduza o " + $"{i+1}" + "º número: ");
                numeros[i] = double.Parse(Console.ReadLine());
                if(numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if(numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("Maior: " + $"{maior}");
            Console.WriteLine("Menor: " + $"{menor}");
        }
    }
}
