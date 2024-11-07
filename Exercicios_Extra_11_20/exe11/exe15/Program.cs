using Microsoft.SqlServer.Server;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max_valores=9999; //Número máximo de valores lidos
            int nr_valores; //Número de valores introduzidos pelo utilizador
            double[] valores = new double[max_valores]; //Array para os valores do utilizador
            double[] min_int = {0.0, 26.0, 51.0, 76.0}; // Definição dos mínimos dos intervalos
            double[] max_int = {25.0, 50.0, 75.0, 100.0}; // Definição dos máximos dos intervalos
            double val_temp=0.0;
            int contador=0, nr_dentro_int = 0;




            Console.WriteLine("Introduza quantos valores vai inserir:");
            nr_valores = int.Parse(Console.ReadLine());

            do
            {
                    Console.WriteLine("Introduza o " + $"{contador + 1}" + "º valor:");
                    valores[contador] = double.Parse(Console.ReadLine());
                    val_temp = valores[contador];
                    
                    for (int i = 0; i< max_int.Length; i++)
                    {
                        if(val_temp >= min_int[i] && val_temp <= max_int[i])
                        {
                        nr_dentro_int++;
                        }

                    }
                contador++;
            } while (val_temp >= 0 && contador < nr_valores);
            Console.WriteLine("Número de valores dentro do intervalo: " + $"{nr_dentro_int}");
        }
    }
}
