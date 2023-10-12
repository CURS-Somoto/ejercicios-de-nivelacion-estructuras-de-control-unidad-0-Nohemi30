/*
Ejercicio 9: Mayor de Dos Números


Dado dos números, muestra el número mayor
utilizando una estructura if

*/
csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
