using System;
using System.Dynamic;
using System.Xml;

namespace Punto_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int confirm,opcion,aux,result,num1,num2;
            string cadena,cadena2;
            do
            {
                do 
                {
                Menu();
                Console.WriteLine("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion <0 || opcion > 10);


                switch (opcion) 
                {
                    case 1: //mostrar algunas letras
                        cadena = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena);
                        Console.WriteLine("Algunos caracteres de la cadena: " + cadena[1] + " " + cadena[3] + " " + cadena[5] + " " + cadena[7] + " " + cadena[9]);
                        break;

                    case 2://largo
                        cadena = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena);
                        Console.WriteLine("Longitud de la cadena: " + cadena.Length);
                        break;

                    case 3://concatenar
                        Console.WriteLine("Primera cadena");
                        cadena = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena);

                        Console.WriteLine("segunda cadena");
                        cadena2 = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena2);


                        Console.WriteLine("Cadena concatenada :" + string.Concat(cadena,cadena2));
                        break;

                    case 4://subcadena
                        cadena = PedirCadena();

                        do
                        {
                            Console.WriteLine("ingese un numero (mayor a 0 y menor al largo de la cadena ingresada): ");
                            aux = Convert.ToInt32(Console.ReadLine());
                        } while (aux <= 0 || aux > cadena.Length);

                        Console.WriteLine("Subcadena creada desde la posicion "+ aux + ":" + cadena.Substring(aux));
                        break;

                    case 5://calculadora

                        Console.WriteLine("Ingrese el primer numero:");
                        num1 = PedirNumero();

                        Console.WriteLine("Ingrese el segundo numero:");
                        num2 = PedirNumero();


                        do
                        {
                            Console.WriteLine("\nOperaciones:\n[1] Sumar\n[2] Restar\n[3] Multiplicar\n[4] Dividir");
                            opcion = Convert.ToInt32(Console.ReadLine());
                        } while (opcion < 1 || opcion > 4);


                        switch (opcion)
                        {
                            case 1:
                                result = num1 + num2;
                                Console.WriteLine("La suma de " + num1 + "+" + num2 + "es igual a " + result);
                                break;
                            case 2:
                                result = num1 - num2;
                                Console.WriteLine("La resta de " + num1 + "-" + num2 + "=" + result);
                                break;
                            case 3:
                                result = num1 * num2;
                                Console.WriteLine("El Producto de " + num1 + "*" + num2 + "=" + result);
                                break;
                            case 4:
                                result = num1 / num2;
                                Console.WriteLine("El cociente de " + num1 + "/" + num2 + "=" + result);
                                break;
                        }

                        break;

                    case 6://foreach
                        cadena = PedirCadena();

                        foreach (char item in cadena)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case 7://buscar palabra
                        cadena = PedirCadena();
                        Console.WriteLine("Ingrese una cadena para buscar");
                        string buscado = Convert.ToString(Console.ReadLine());

                        if (cadena.Contains(buscado))
                        {
                            Console.WriteLine("La string:[" + cadena + "] contiene la palabra [" + buscado + "]");
                        }
                        else
                        {
                            Console.WriteLine("La string:[" + cadena + "] NO contiene la palabra [" + buscado + "]");
                        }
                        break;

                    case 8://may y min
                        cadena = PedirCadena();
                        Console.WriteLine("Cadena en minusculas: " + cadena.ToLower());
                        Console.WriteLine("Cadena en Mayusculas: " + cadena.ToUpper());
                        break;

                    case 9:// comparar valores
                        Console.WriteLine("Primera cadena");
                        cadena = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena);

                        Console.WriteLine("segunda cadena");
                        cadena2 = PedirCadena();
                        Console.WriteLine("Cadena ingresada: " + cadena2);

                        if (string.Compare(cadena, cadena2) == 0)
                        {
                            Console.WriteLine("Ambas cadenas son iguales");
                        }
                        else
                        {
                            if (string.Compare(cadena, cadena2) > 0)
                            {
                                Console.WriteLine("La cadena [" + cadena + "] es mayor a la cadena [" + cadena2 + "]");
                            }
                            else
                            {
                                Console.WriteLine("La cadena [" + cadena + "] es menor a la cadena [" + cadena2 + "]");
                            }
                        }
                        break;

                    case 10://separar cadena con un char split()

                        char separador;
                        string[] arreglo;

                        cadena = PedirCadena();

                        Console.WriteLine("Ingrese una letra, cada iteracion de esa letra separara la cadena en esa posicion:");
                        separador = Convert.ToChar(Console.ReadLine()); //pedir una letra

                        arreglo = cadena.Split(separador.ToString()); //se la pasa a un arreglo para poder separarlo

                        foreach (string item in arreglo) //item es cada entrada del array (para cada string del arreglo)
                        {
                            Console.WriteLine(item);  
                        }
                        break;

                    //case 11://segunda calculadora
                    //    break;
                }  





                Console.WriteLine("Realizar otra operacion? [SI = 1/NO = 0]");
                confirm = Convert.ToInt32(Console.ReadLine());
                opcion = 0;
            } while (confirm == 1);


        }

        public static void Menu() 
        {
            Console.WriteLine("==============================================MENU==============================================");
            Console.WriteLine("OPCIONES: ");
            Console.WriteLine("[1]Mostrar algunos caracteres de la cadena");
            Console.WriteLine("[2]Longitud de la cadena");
            Console.WriteLine("[3]Concatenar 2 cadenas");
            Console.WriteLine("[4]Subcadena a partir de un aux");
            Console.WriteLine("[5]Usar la calculadora");
            Console.WriteLine("[6]Recorrer el arreglo a partir de un aux");
            Console.WriteLine("[7]Buscar parabra dentro del arreglo");
            Console.WriteLine("[8]Transformar string en mayusculas y minusculas");
            Console.WriteLine("[9]Comparar valores");
            Console.WriteLine("[10]Separar strings por caracter ingresado");
            Console.WriteLine("================================================================================================");
        }

        public static string PedirCadena()
        {
            string Cadena;
            do
            {
                Console.WriteLine("Ingrese una cadena");
                Cadena = Convert.ToString(Console.ReadLine());
            } while (string.IsNullOrEmpty(Cadena));
            return Cadena;
        }

        public static int PedirNumero()
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero Ingresado:[" + num + "]");
            return num;
        }
    }
      
    
   
}
  
