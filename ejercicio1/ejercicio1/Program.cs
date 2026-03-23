// 1. Crear una pila y agregar 4 numeros.

using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);
        pila.Push(40);

        Console.WriteLine("El contenido de la pila (del último al primero):");
        foreach (int n in pila)
        {
            Console.WriteLine(n);
        }
    }
}