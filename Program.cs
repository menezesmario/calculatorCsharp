﻿using System;

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

            Console.WriteLine("Qual cálculo deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione a operação: ");
            
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }

        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }


        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            
            Console.ReadKey();
            Menu();
        }
    }
}
