// Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < 7; i++)
        {
            Console.Write("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        Console.Write("Ingrese otro numero para buscar: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        if (numeros.Contains(numeroBuscado))
        {
            Console.WriteLine("el numero si se encuentra en la lista.");
        }
        else
        {
            Console.WriteLine("el numero no se encuentra en la lista.");
        }
    }
}