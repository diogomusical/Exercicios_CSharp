using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double numero_total = 0;
            int nr_pares = 0;
            double numero;

            do
            {
                Console.WriteLine("Introduza um numero: ");
                numero = double.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    numero_total += numero;
                    nr_pares++;
                }
            } while (numero != 0);

            if (nr_pares == 1)
            {
                Console.WriteLine("Não tem números pares");
            }
            else
            {
                Console.WriteLine("Média dos números pares: " + $"{numero_total / (nr_pares - 1)}");
            }
        }
    }
}
