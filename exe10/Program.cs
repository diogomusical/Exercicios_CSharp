using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr_notas = 3, i_nota_maior = 0;
            int cod_aluno, nr=0;
            double[] notas = new double[nr_notas];
            double media=0;

            do
            {
                Console.WriteLine("Introduza o código do " + $"{nr+1}" + "º aluno: ");
                cod_aluno = int.Parse(Console.ReadLine());
                
                if(cod_aluno > 0)
                {
                    //Carregamento das notas introduzidas pelo utilizador
                    for(int i = 0;i  < nr_notas; i++)
                    {
                        Console.WriteLine("Introduza a " + $"{i+1}" + "º nota: ");
                        notas[i] = double.Parse(Console.ReadLine());
                    }
                    nr++;

                    //Obtençao do indice da nota maior
                    for (int i = 0; i < nr_notas; i++)
                    {
                        if(notas[i] > notas[i_nota_maior])
                        {
                            i_nota_maior = i;
                        }
                    }

                    //Calculo da média
                    for(int i = 0; i < nr_notas; i++)
                    {
                        if (i == i_nota_maior)
                        {
                            media += 4*notas[i_nota_maior];
                        }
                        else
                        {
                            media += 2 * notas[i];
                        }
                    }

                    media = media / 8;

                    if(media >= 5)
                    {
                        Console.WriteLine("APROVADO COM MÉDIA: " + $"{media}");
                    }
                    else
                    {
                        Console.WriteLine("REPROVADOO COM MÉDIA: " + $"{media}");
                    }

                }

            } while (cod_aluno > 0);
        }
    }
}
