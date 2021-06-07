using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
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
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
        }
    }
}
