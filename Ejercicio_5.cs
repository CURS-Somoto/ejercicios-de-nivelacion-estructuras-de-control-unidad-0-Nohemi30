/*Ejercicio 5: Positivo o negativo


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.*/
csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else
        {
            Console.WriteLine("El número es cero");
        }

        Console.ReadLine();
    }
}


En este programa, se le solicita al usuario ingresar un número entero, que se guarda en la variable numero.

Luego, se realiza una serie de comprobaciones para determinar si el número es positivo, negativo o cero. Si el número es mayor que cero
