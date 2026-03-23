// 2. Recorrer y Eliminar todos los elementos.

using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);
        pila.Push(4);
        Console.WriteLine("Iniciando vaciado de la pila...");
        while (pila.Count > 0)
        {
            int n = pila.Pop();
            Console.WriteLine("Eliminé el número: " + n);
        }
        Console.WriteLine("\n¿Cuántos elementos quedan? " + pila.Count);
        Console.WriteLine("La pila está vacía ahora.");
        Console.ReadLine();
    }
}