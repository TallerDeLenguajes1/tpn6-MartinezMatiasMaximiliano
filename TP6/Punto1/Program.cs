using System;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, invert = 0;

            Console.WriteLine("Escriba un numero a invertir (menor o igual a 0 no se convertiran): ");
            num = Convert.ToInt32(Console.ReadLine());  //recibe un string, se debe convertir a int

            Console.WriteLine("Numero ingresado: " + num);

            if (num > 0)
            {
                while (num > 0)
                {

                    invert = num % 10 + invert * 10;
                    num = num / 10;
                }
                Console.WriteLine("Numero invertido: " + invert);
            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine("No se realizo la conversion:[el numero es igual a 0]");
                }
                else
                {
                    Console.WriteLine("No se realizo la conversion:[el numero es menor a 0]");
                }
            }
        }
    }
}
