using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            string[] nomes = new string[10];

            Console.WriteLine("Digite o 1° nome: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite o 2° nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite o 3° nome: ");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Digite o 4° nome: ");
            string nome4 = Console.ReadLine();
            Console.WriteLine("Digite o 5° nome: ");
            string nome5 = Console.ReadLine();
            Console.WriteLine("Digite o 6° nome: ");
            string nome6 = Console.ReadLine();
            Console.WriteLine("Digite o 7° nome: ");
            string nome7 = Console.ReadLine();
            Console.WriteLine("Digite o 8° nome: ");
            string nome8 = Console.ReadLine();
            Console.WriteLine("Digite o 9° nome: ");
            string nome9 = Console.ReadLine();
            Console.WriteLine("Digite o 10° nome: ");
            string nome10 = Console.ReadLine();

            Console.Clear();

            nomes[0] = nome1;
            nomes[1] = nome2;
            nomes[2] = nome3;
            nomes[3] = nome4;
            nomes[4] = nome5;
            nomes[5] = nome6;
            nomes[6] = nome7;
            nomes[7] = nome8;
            nomes[8] = nome9;
            nomes[9] = nome10;

            Console.WriteLine(nomes[0] + ", " + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + ", " + nomes[4] + ", " + nomes[5] + ", " + nomes[6] + ", " + nomes[7] + ", " + nomes[8] + ", " + nomes[9]);
        }
    }
}
