// See https://aka.ms/new-console-template for more information
using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRACAO");
            Console.WriteLine("3 - DIVISAO");
            Console.WriteLine("4 - MULTIPLICACAO");
            Console.WriteLine("5- Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;

                default: Soma(); break;

            }

        }
        static float[] Leitura()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float[] valores = { v1, v2 };
            return valores;
        }
        static void Soma()
        {

            Console.WriteLine();
            var valores = Leitura();
            Console.WriteLine("o Resultado da soma é " + (valores[0] + valores[1]));
            Console.WriteLine("Valeu por usar nossa App");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {

            Console.WriteLine();
            var valores = Leitura();
            Console.WriteLine("o Resultado da subtracao é " + (valores[0] - valores[1]));
            Console.WriteLine("Valeu por usar nossa App");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {

            Console.WriteLine();
            var valores = Leitura();
            Console.WriteLine("o Resultado da divisao é " + (valores[0] / valores[1]));
            Console.WriteLine("Valeu por usar nossa App");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {

            Console.WriteLine();
            var valores = Leitura();
            Console.WriteLine("o Resultado da multiplicacao é " + (valores[0] * valores[1]));
            Console.WriteLine("Valeu por usar nossa App");
            Console.ReadKey();
            Menu();
        }
    }
}
