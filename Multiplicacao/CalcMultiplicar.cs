using System;
using System.Collections.Generic;
using System.Text;

namespace Victor_Robinson_TP1.Multiplicacao
{
    public class CalcMultiplicar
    {
        public static void Multiplicar()
        {
            Console.WriteLine("Insira um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora outro: ");
            int valor2 = int.Parse(Console.ReadLine());

            int multiplicar = valor1 * valor2;

            Console.WriteLine("A multiplicação é: " + multiplicar);

        }
    }
}
