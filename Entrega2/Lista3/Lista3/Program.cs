using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        List<int> numeros = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            int numeroAleatorio = rand.Next(1, 101); 
            numeros.Add(numeroAleatorio);
        }

        Console.WriteLine("Lista original:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nIngrese un valor limite:");
        int limite = int.Parse(Console.ReadLine());

        numeros.RemoveAll(n => n < limite);

        Console.WriteLine("\nLista despues de eliminar los menores a " + limite + ":");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
    }
}