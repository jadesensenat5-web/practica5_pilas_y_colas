//4.  Crear una cola y agregar 5 numeros.
using System;
using System.Collections.Generic; 
class Ejercicio4
{
    static void Main()
    {
        Queue<int> miCola = new Queue<int>();
        Console.WriteLine("--- EJERCICIO 4: COLAS (QUEUES) ---");
        Console.WriteLine("Creando cola vacía...");
        Console.WriteLine("Agregando 5 números a la cola:");
        miCola.Enqueue(10);
        miCola.Enqueue(20);
        miCola.Enqueue(30);
        miCola.Enqueue(40);
        miCola.Enqueue(50);
        Console.WriteLine("¡Números agregados correctamente!");
        Console.WriteLine("\nContenido de la cola (en orden de llegada):");
        Console.WriteLine("-------------------------------------------");
        foreach (int numero in miCola)
        {
            Console.WriteLine("En la fila: " + numero);
        }
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Total de elementos: " + miCola.Count);
        Console.ReadLine();
    }
}
