using System;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, confirm = 1,opcion = 0,result;



            do
            {
                Console.WriteLine("Ingrese el primer numero:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Primer numero:[" + num1 + "]");


                Console.WriteLine("Ingrese el segundo numero:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("segundo numero numero:[" + num2 + "]");

                do
                {
                    Console.WriteLine("\nOperaciones:\n[1] Sumar\n[2] Restar\n[3] Multiplicar\n[4] Dividir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion < 1 || opcion > 4);


                switch (opcion)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + result);
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(num1 + "-" + num2 + "=" + result);
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(num1 + "*" + num2 + "=" + result);
                        break;
                    case 4:
                        result = num1 / num2;
                        Console.WriteLine(num1 + "/" + num2 + "=" + result);
                        break;
                }


                Console.WriteLine("Realizar otra operacion? [SI = 1 / NO = 0]");
                confirm = Convert.ToInt32(Console.ReadLine());
            } while (confirm == 1);


        }
    }
}
