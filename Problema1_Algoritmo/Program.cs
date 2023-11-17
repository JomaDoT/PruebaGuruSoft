using System;
using System.Text;

namespace Problema1_Algoritmo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcionRepetir = false;
            do
            {
                Console.WriteLine("Este sistema devolvera el valor que esta en la mitad del valor digitado.");
                Console.WriteLine("Ejemplo si digita pip, devolvera i que es valor que queda en el medio de pip.");
                Console.WriteLine("Por favor digite alguna informacion con mas de dos caracteres(numeros, letras, simbolos,etc).");
                Console.WriteLine();
                var value = Console.ReadLine();

                //validaicones
                if (value is null || value is { Length: <= 2 })
                {
                    Console.WriteLine("No se puede buscar el valor que se encuentra en la mitad de dos o menos caracteres");
                    opcionRepetir = false;
                }
                else
                {
                    StringBuilder stringBuilder = new();

                    //se limpian los espacio.
                    value.Trim();

                    int longitud = value.Length;

                    //si la longitud es par quiere decir que tomaremos:
                    //el caracter que se encuentre en la posicion del resultado de la longitud divida por 2
                    //el caracter que se encuentre en la posicion del resultado de la longitud divida por 2 + 1
                    // esto devolvera los dos caracteres que esten en el medio
                    //si la longitud es impar quiere decir que tomaremos:
                    //el resultado de la longitud divida por 2

                    int caracter1 = longitud / 2;
                    if ((longitud % 2) == 0)
                    {
                        int caracter2 = (longitud / 2) + 1;
                        stringBuilder.Append(value[(caracter1 - 1)]);
                        stringBuilder.Append(value[(caracter2 - 1)]);
                    }
                    else
                        stringBuilder.Append(value[(caracter1)]);

                    Console.WriteLine(stringBuilder.ToString());

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
            } while (opcionRepetir) ;           
        }
    }
}



 