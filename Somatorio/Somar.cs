using System;
using System.Collections.Generic;
using System.Text;

namespace Victor_Robinson_TP1.Somatorio
{
    public class CalcSomar
    {
         public static void Somar()
        {
            Console.WriteLine("Insira um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora outro: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("A soma é: " + soma);

        }

    }
}
