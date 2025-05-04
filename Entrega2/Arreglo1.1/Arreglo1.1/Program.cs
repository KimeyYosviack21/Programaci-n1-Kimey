// Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.

using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Ingrese los numeros para la matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Numero [" + i + "," + j + "]: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nSumas de las filas:");
        for (int i = 0; i < 3; i++)
        {
            int suma = matriz[i, 0] + matriz[i, 1] + matriz[i, 2];
            Console.WriteLine("Fila " + i + ": " + suma);
        }
    }
}