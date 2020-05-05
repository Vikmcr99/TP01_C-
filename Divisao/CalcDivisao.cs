using System;
using System.Collections.Generic;
using System.Text;

namespace Victor_Robinson_TP1.Divisao
{
    public class CalcDivisao
    {
        public static void Dividir()
        {
            Console.WriteLine("Insira um valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora outro: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor2 == 0)
            {
                Console.WriteLine("Não pode fazer dvisão por zero!");
                Environment.Exit(0);
            }

            else
            {
                int dividir = valor1 / valor2;
                Console.WriteLine("A divisão é: " + dividir);
            }
        }
    }
}
