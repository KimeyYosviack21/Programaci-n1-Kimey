using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[8];
        int contadorA = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Escribe un nombre: ");
            nombres[i] = Console.ReadLine();

            if (nombres[i].StartsWith("A") || nombres[i].StartsWith("a"))
            {
                contadorA++;
            }
        }

        Console.WriteLine("Cantidad de nombres que empiezan con 'A': " + contadorA);
    }
}