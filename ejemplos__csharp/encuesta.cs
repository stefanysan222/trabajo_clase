using System;
using System.Collections.Generic;

class EncuestaSatisfaccion
{
    static void Main()
    {
        List<int> calificaciones = new List<int>();
        string respuesta;

        Console.WriteLine("=== Encuesta de Satisfacción ===");
        Console.WriteLine("Califique su experiencia (1 = Muy mala, 5 = Excelente)");

        do
        {
            int calificacion;

            // Validar que sea número entre 1 y 5
            while (true)
            {
                Console.Write("Ingrese calificación (1-5): ");
                if (int.TryParse(Console.ReadLine(), out calificacion) && calificacion >= 1 && calificacion <= 5)
                {
                    calificaciones.Add(calificacion);
                    break;
                }
                else
                {
                    Console.WriteLine("⚠ Por favor ingrese un número válido entre 1 y 5.");
                }
            }

            Console.Write("¿Desea ingresar otra calificación? (s/n): ");
            respuesta = Console.ReadLine().ToLower();

        } while (respuesta == "s");

        // Calcular promedio
        double promedio = 0;
        if (calificaciones.Count > 0)
        {
            promedio = (double)SumarLista(calificaciones) / calificaciones.Count;
        }

        Console.WriteLine($"\nTotal de encuestas: {calificaciones.Count}");
        Console.WriteLine($"Promedio de satisfacción: {promedio:F2} / 5");
    }

    static int SumarLista(List<int> lista)
    {
        int suma = 0;
        foreach (var num in lista)
        {
            suma += num;
        }
        return suma;
    }
}
