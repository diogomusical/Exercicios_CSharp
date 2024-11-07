using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr_maximo = 9999;
            int nr_valores;
            int[] valores = new int[nr_maximo];
            int[] factorial = new int[nr_maximo];

            Console.WriteLine("Introduza o número de valores que pretende introduzir: ");
            nr_valores = int.Parse(Console.ReadLine());

            //Carregamentos dos valores introduzidos pelo utilizador
            for (int i = 0; i < nr_valores; i++)
            {
                Console.WriteLine("Introduza o " + $"{i + 1}" + "º número:");
                valores[i] = int.Parse(Console.ReadLine());
            }

            //Calculo do factorial
            for (int i = 0; i < nr_valores; i++)
            {
                factorial[i] = 1;
                for (int j = 1; j < valores[i]; j++)
                {
                    factorial[i] = (j+1)*factorial[i];
                }
            }

            //Visualização de tabela de factoriais
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t------------------");
            Console.WriteLine("\t|Valor\t|Factorial|");
            Console.WriteLine("\t------------------");
            for (int i = 0;i < nr_valores; i++)
            {
                Console.WriteLine("\t|" + $"{valores[i]}" + "\t|" + $"{factorial[i]}" + "\t|");
                
            }
            Console.WriteLine("\t------------------");

        }
    }
}
