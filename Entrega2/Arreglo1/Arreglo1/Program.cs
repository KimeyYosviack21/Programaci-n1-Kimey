// Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.

int[] numeros = new int[10];
Random aleatorio = new Random();

int mayor = 0;
int menor = 101;

for (int i = 0; i < 10; i++)
{
    numeros[i] = aleatorio.Next(1, 101);
    Console.Write(numeros[i] + " ");

    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("El número mayor es: " + mayor);
Console.WriteLine("El número menor es: " + menor);