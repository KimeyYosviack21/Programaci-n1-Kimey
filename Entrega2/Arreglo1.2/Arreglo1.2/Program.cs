// Cargar una matriz de 3x3. Mostrar la fila con mayor suma.

using System;

class Programa
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int mayorSuma = 0;
        int fila = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Ingrese un numero para la fila {0}, columna {1}: ", i + 1, j + 1);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            int sumaFila = matriz[i, 0] + matriz[i, 1] + matriz[i, 2];

            if (sumaFila > mayorSuma)
            {
                mayorSuma = sumaFila;
                fila = i;
            }
        }

        Console.WriteLine("La fila con la mayor suma es la Fila " + (fila + 1));
    }
}