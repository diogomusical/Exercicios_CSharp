using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int nr_maximo_pessoas = 9999;
            double[] salarios = new double[nr_maximo_pessoas];
            int[] nr_filhos = new int[nr_maximo_pessoas];
            double total_salarios = 0, total_filhos = 0;
            double maior_salario = 0;
            double per_ate_100 = 0;

            do
            {
                i++;
                Console.WriteLine("Salário da " + $"{i}" + "ª pessoa: ");
                salarios[i-1] = double.Parse(Console.ReadLine());
                if (salarios[i-1] >= 0)
                {
                    Console.WriteLine("Introduza o número de filhos: ");
                    nr_filhos[i - 1] = int.Parse(Console.ReadLine());
                    total_filhos += nr_filhos[i - 1];
                    total_salarios += salarios[i - 1];
                    if (salarios[i-1] > maior_salario)
                    {
                        maior_salario = salarios[i-1];
                    }
                    if (salarios[i - 1] <= 1000)
                    {
                        per_ate_100++;
                    }
                }
            }
            while (salarios[i-1] >= 0);

            Console.WriteLine("Média de salário: " + $"{total_salarios / (i-1)}");
            Console.WriteLine("Média do nr de filhos: " + $"{total_filhos / (i-1)}"); 
            Console.WriteLine("Maior salário: " + $"{maior_salario}");
            Console.WriteLine("Percentagem que recebem até 1000€:" + $"{per_ate_100}");
        }
    }
} 
