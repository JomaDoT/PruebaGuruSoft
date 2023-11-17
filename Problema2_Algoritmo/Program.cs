using System;
using System.Text;

namespace Problema2_Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcionRepetir = false;
            do
            {
                Console.WriteLine("Este sistema devolvera la cantidad de numero primos a partir de un numero hasta la cantidad de veces que decida.");
                Console.WriteLine("Ejemplo si digita buscar a partir del numero 3 y la cantidad maxima de resultados es 5,el sistema devolvera 3,5,7,9,11");
                Console.WriteLine();
                Console.WriteLine("Por favor digite el numero a patir de cual quiere comenzar a buscar:");
                Console.WriteLine();
                var initialValue = Console.ReadLine();

                //validaciones
                if (string.IsNullOrEmpty(initialValue))
                {
                    Console.WriteLine("No se puede iniciar a buscar los numeros primos si no introduce ningun valor");
                    opcionRepetir = false;
                }
                Console.WriteLine("Por favor digite la cantidad maxima de resultado requeridos:");
                Console.WriteLine();
                var endValue = Console.ReadLine();

                //validaciones
                if (string.IsNullOrEmpty(endValue) || Convert.ToInt32(endValue) <= 0)
                {
                    Console.WriteLine("Debe introducir el maximo de numeros primos que quiere buscar.");
                    opcionRepetir = false;
                }

                else
                {
                    StringBuilder stringBuilder = new();

                    //se limpian los espacio.
                    initialValue.Trim();
                    endValue.Trim();

                    //se convierten los valores
                    int firstValue = Convert.ToInt32(initialValue);
                    int secondValue = Convert.ToInt32(endValue);

                    // se busca los impares hasta el maximo introducido
                    for (int i = firstValue; stringBuilder.Length < secondValue; i++)
                    {
                        if ((i % 2) != 0)
                            stringBuilder.Append(i);
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Los {endValue} numeros primos a partir de {firstValue} son: \n{stringBuilder.ToString()}");
                    Console.WriteLine();

                    Console.WriteLine("Si desea consultar otra informacion escriba 1 de lo contrario escriba 0.");
                    var opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            opcionRepetir = true;
                            break;
                        default:
                            opcionRepetir = false;
                            break;
                    }
                    Console.WriteLine();
                }
            } while (opcionRepetir);
        }
    }
}



