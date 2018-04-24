using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nomes = new string[7];
            double[] valores = new double[7];

            Console.Write("Produto 01\n");
            Console.Write("Nome: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 02\n");
            Console.Write("Nome: ");
            nomes[1] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 03\n");
            Console.Write("Nome: ");
            nomes[2] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 04\n");
            Console.Write("Nome: ");
            nomes[3] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 05\n");
            Console.Write("Nome: ");
            nomes[4] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 06\n");
            Console.Write("Nome: ");
            nomes[5] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[5] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Produto 07\n");
            Console.Write("Nome: ");
            nomes[6] = Console.ReadLine();
            Console.Write("Preço: ");
            valores[6] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O nome e o preço é: " + nomes[0] + ", " + valores[0]);
            Console.WriteLine("O nome e o preço é: " + nomes[1] + ", " + valores[1]);
            Console.WriteLine("O nome e o preço é: " + nomes[2] + ", " + valores[2]);
            Console.WriteLine("O nome e o preço é: " + nomes[3] + ", " + valores[3]);
            Console.WriteLine("O nome e o preço é: " + nomes[4] + ", " + valores[4]);
            Console.WriteLine("O nome e o preço é: " + nomes[5] + ", " + valores[5]);
            Console.WriteLine("O nome e o preço é: " + nomes[6] + ", " + valores[6]);
        }
    }
}
