// Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int suma = 0;

        Console.WriteLine("Ingrese 5 numeros enteros:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Numero " + (i + 1) + ": ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
            suma = suma + numero;
        }

        Console.WriteLine("La suma total es: " + suma);
    }
}