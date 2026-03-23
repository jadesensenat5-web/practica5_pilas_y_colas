// 3. Agregar 3, eliminar 2 y mostrar estado.

using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        Stack<string> miPila = new Stack<string>();
        miPila.Push("Elemento 1");
        miPila.Push("Elemento 2");
        miPila.Push("Elemento 3");
        Console.WriteLine("Se agregaron 3 elementos.");
        miPila.Pop(); 
        miPila.Pop(); 
        Console.WriteLine("Se eliminaron 2 elementos.");
        Console.WriteLine("\n--- ESTADO FINAL DE LA PILA ---");

        if (miPila.Count > 0)
        {
            foreach (var item in miPila)
            {
                Console.WriteLine("Queda en la pila: " + item);
            }
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
        Console.ReadLine();
    }
}