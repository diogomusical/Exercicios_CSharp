using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod_aluno;
            double[] notas = new double[3];
            double total_notas = 0;

            do
            {
                Console.WriteLine("Introduza o número do aluno: ");
                cod_aluno = int.Parse(Console.ReadLine());

                if (cod_aluno != 0)
                {
                    //Carregamento das notas
                    for (int i = 0; i < notas.Length; i++)
                    {
                        Console.WriteLine("Nota " + $"{i + 1}" + "ª: ");
                        notas[i] = double.Parse(Console.ReadLine());
                        total_notas += notas[i];
                    }
                    Console.WriteLine("Media: "+ $"{total_notas / 3.0}");
                }

            } while (cod_aluno != 0);

        }
    }
}
