using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números.
            // Luego analizar e informar por pantalla si los mismos se
            // encuentran ordenados de forma decreciente .
            int n1, n2, n3, n4;
            Console.WriteLine("Escribe un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el último:");
            n4 = int.Parse(Console.ReadLine());
            if((n1 > n2) && (n2 > n3) && (n3 > n4))
            Console.WriteLine("Están ordenados de forma decreciente");

        }
    }
}
