using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] nr_candidatos = new int[6];
            do
            {
                Console.WriteLine("Escolha o seu candidato");
                Console.WriteLine("\t1 - Candidato 1");
                Console.WriteLine("\t2 - Candidato 2");
                Console.WriteLine("\t3 - Candidato 3");
                Console.WriteLine("\t4 - Candidato 4");
                Console.WriteLine("\t5 - Voto Nulo");
                Console.WriteLine("\t6 - Voto Branco");
                Console.WriteLine("\t0 - PARA SAIR");
                Console.WriteLine("Introduza um número: ");
                numero = int.Parse(Console.ReadLine());

             
                //Contagem dos votos
                for(int i = 0;i < nr_candidatos.Length; i++)
                {
                    if (numero-1 == i)
                    {
                        nr_candidatos[i]++;
                    } ;
                }

                Console.WriteLine("Número total de votos:");

            } while (numero != 0);

            //Visualização de voto
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Candidato " + $"{i + 1}" + ":" + "\t" + $"{nr_candidatos[i]}");
            }
            Console.WriteLine("Número de votos nulos:" + "\t" + $"{nr_candidatos[4]}");
            Console.WriteLine("Número de votos brancos:" + $"{nr_candidatos[5]}");

        }
    }
}
