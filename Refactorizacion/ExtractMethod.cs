//Extract Method sin refactorizar

using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20 };
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        double promedio = (double)suma / numeros.Length;
        Console.WriteLine("El promedio es: " + promedio);
    }
}


//Extract Method refactorizado



class Program
{
    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20 };
        Console.WriteLine("El promedio es: " + CalcularPromedio(numeros));
    }

    static double CalcularPromedio(int[] valores)
    {
        int suma = 0;
        foreach (var v in valores)
        {
            suma += v;
        }
        return (double)suma / valores.Length;
    }
}

// Se  toma el bloque de codigo repetitivo y se movio a un metodo separado.
// Mejorando la legibilidad y mantenibilidad del codigo.
// Permite reutilizar en otros lugares sin duplicar codigo.
// Facilita las pruebas unitarias al aislar la logica en un metodo independiente.
