// 5. Sumar elementos de una cola.
using System;
using System.Collections.Generic;

class Ejercicio5
{
    static void Main()
    {
        Queue<int> miCola = new Queue<int>();
        miCola.Enqueue(10);
        miCola.Enqueue(20);
        miCola.Enqueue(30);
        miCola.Enqueue(40);
        miCola.Enqueue(50);
        Console.WriteLine("Calculando la suma de los elementos en la cola...");
        Console.WriteLine("Elementos: 10, 20, 30, 40, 50");
        int total = SumarCola(miCola);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("EL TOTAL DE LA SUMA ES: " + total);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("\nPresiona ENTER para cerrar...");
        Console.ReadLine();
    }
    static int SumarCola(Queue<int> c)
    {
        int suma = 0;
        foreach (int numero in c)
        {
            suma += numero;
        }
        return suma;
    }
}