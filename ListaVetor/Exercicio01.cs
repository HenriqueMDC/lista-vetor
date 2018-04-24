using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numeros = new int[16];

            Console.WriteLine("Digite 1° numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 2° numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 3° numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 4° numero: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 5° numero: ");
            int numero5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 6° numero: ");
            int numero6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 7° numero: ");
            int numero7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 8° numero: ");
            int numero8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 9° numero: ");
            int numero9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 10° numero: ");
            int numero10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 11° numero: ");
            int numero11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 12° numero: ");
            int numero12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 13° numero: ");
            int numero13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 14° numero: ");
            int numero14 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 15° numero: ");
            int numero15 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite 16° numero: ");
            int numero16 = Convert.ToInt32(Console.ReadLine());



            numeros[0] = + numero1;
            numeros[1] = + numero2;
            numeros[2] = + numero3;
            numeros[3] = + numero4;
            numeros[4] = + numero5;
            numeros[5] = + numero6;
            numeros[6] = + numero7;
            numeros[7] = + numero8;
            numeros[8] = + numero9;
            numeros[9] = + numero10;
            numeros[10] = + numero11;
            numeros[11] = + numero12;
            numeros[12] = + numero13;
            numeros[13] = + numero14;
            numeros[14] = + numero15;
            numeros[15] = + numero16;

            double soma = (numero1 + numero2 + numero3 + numero4 + numero5 + numero6 + numero7 + numero8 + numero9 + numero10 + numero11 + numero12 + numero13 + numero14 + numero15 + numero16);

            Console.WriteLine("Soma dos números: " + soma);
        }
    }
}
