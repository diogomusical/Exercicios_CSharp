using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura_chico = 1.50;
            double altura_ze = 1.10;
            int i=0;

            while (altura_chico >= altura_ze)
            {
                altura_chico += 0.02;
                altura_ze += 0.03;
                i++;
            }

            Console.WriteLine("Anos para Zé ser Maior que Chico: " + $"{i}");
        }
    }
}
