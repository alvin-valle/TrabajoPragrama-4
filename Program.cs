using System;
using Trabajo4;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Trabajo4.Universidad.Estudiante;

class Program
{
    static void Main(string[] args)
    {

        Universidad universidad = new Universidad { Nombre = "Mi Universidad" };

        Universidad.Estudiante[] estudiantes = new Universidad.Estudiante[5];

        for (int i = 0; i < estudiantes.Length; i++)
        {
            estudiantes[i] = new Universidad.Estudiante();

            Console.WriteLine($"Ingrese el nombre del estudiante {i + 1}: ");
            estudiantes[i].Nombre = Console.ReadLine();

            Console.WriteLine($"Ingrese el total de sesiones para {estudiantes[i].Nombre}: ");
            estudiantes[i].SesionesTotales = int.Parse(Console.ReadLine());

           
            bool sesionValida = false;
            while (!sesionValida)
            {
                Console.WriteLine($"Ingrese las sesiones asistidas por {estudiantes[i].Nombre}: ");
                estudiantes[i].SesionesAsistidas = int.Parse(Console.ReadLine());

                if (estudiantes[i].SesionesAsistidas > estudiantes[i].SesionesTotales)
                {
                    Console.WriteLine("Error: Las sesiones asistidas no pueden ser mayores que el total de sesiones. Intente nuevamente.");
                }
                else
                {
                    sesionValida = true; 
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Resumen de Asistencia:");

        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine(estudiante.MostrarInformacion());
        }
    }
}