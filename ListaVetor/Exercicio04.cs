using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            double[] notas = new double[4];

            Console.WriteLine("Disciplina: ");
            string disciplina = Console.ReadLine();

            Console.WriteLine("Nota 01: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            Console.WriteLine("Sua média é: " + media);
        }
    }
}
