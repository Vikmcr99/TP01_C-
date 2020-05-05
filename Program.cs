using System;
using Victor_Robinson_TP1.Somatorio;
using Victor_Robinson_TP1.Subtracao;
using Victor_Robinson_TP1.Multiplicacao;
using Victor_Robinson_TP1.Divisao;

namespace Victor_Robinson_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine(" Escolha uma operação:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            string input = Console.ReadLine();

            if (input == "1")
            {
                CalcSomar.Somar();
            }
            else if (input == "2") 
            {
                CalcSubracao.Subtrair();
            }
            else if (input == "3")
            {
                CalcMultiplicar.Multiplicar();
            }
            else if (input == "4")
            {
                CalcDivisao.Dividir();
            }
            else if (input =="5")
            {
                Console.WriteLine("Saindo...");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Número Invalido!");
            }

        }
    }
}

