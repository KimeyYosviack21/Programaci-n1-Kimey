// Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.

using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Ingrese un numero para la fila {0}, columna {1}: ", i + 1, j + 1);
                matriz[i, j] = int.Parse(Console.ReadLine());

                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = 0;
                }
            }
        }

        Console.WriteLine("La matriz final es:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}