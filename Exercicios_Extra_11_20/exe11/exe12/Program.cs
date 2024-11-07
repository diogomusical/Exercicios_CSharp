using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr_valores = 5;
            int[] valores = new int[nr_valores];

            //Carregamento dos valores inseridos pelo utilizador
            for (int i = 0; i < nr_valores; i++)
            {
                Console.WriteLine("Introduza o " + $"{i + 1}" + "º número:");
                valores[i] = int.Parse(Console.ReadLine());
            }

            //Visualização dos dados
            for (int i = 0; i < nr_valores; i++)
            {
                Console.WriteLine("\n\n\n");
                for (int j = 0; j < valores[i]; j++)
                {
                    Console.WriteLine("\t" + $"{j+1}" + " x " + $"{valores[i]}" + " = " + $"{(j+1) * valores[i]}");
                }
            }

            Console.WriteLine("\n\n FIM DO PROGRAMA");

        }
    }
}
