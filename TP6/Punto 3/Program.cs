using System;
using System.Xml;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1,num2;
            Console.WriteLine("Ingrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Valor absoluto: [" + Math.Abs(num1) +"]");
            Console.WriteLine("Cuadrado: [" + Math.Pow(num1,2) + "]");
            Console.WriteLine("Raiz Cuadrada: [" + Math.Sqrt(num1) +"]");
            Console.WriteLine("Seno: [" + Math.Sin(num1) + "]");
            Console.WriteLine("Coseno: [" + Math.Cos(num1) + "]");
            Console.WriteLine("Parte entera de un float: ["+ Math.Round(num1) + "]");



            Console.Write("\nIngrese el primer numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("El maximo es: " + Math.Max(num1, num2));
            Console.WriteLine("El minimo es: " + Math.Min(num1, num2));

        }
    }
}
