// Crear un array con los días de la semana y mostrar solo los días laborales.

using System;

class Programa
{
    static void Main()
    {
        string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        Console.WriteLine("Dias laborales:");
        for (int i = 0; i < 5; i++) // Solo de lunes (índice 0) a viernes (índice 4)
        {
            Console.WriteLine(diasSemana[i]);
        }
    }
}