using System;
using System.Collections.Generic;
using System.Text;

namespace Victor_Robinson_TP1.Subtracao
{
   public class CalcSubracao
    {
        public static void Subtrair()
        {
            Console.WriteLine("Insira um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora outro: ");
            int valor2 = int.Parse(Console.ReadLine());

            int subtrair = valor1 - valor2;

            Console.WriteLine("A subtração é: " + subtrair);

        }
    }
}
