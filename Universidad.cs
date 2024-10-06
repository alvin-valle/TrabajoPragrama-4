using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4
{

    public class Universidad
    {
        public string Nombre { get; set; }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public int SesionesTotales { get; set; }
            public int SesionesAsistidas { get; set; }


            public class Asistencia
            {
                public static double CalcularPorcentaje(int sesionesAsistidas, int sesionesTotales)
                {
                    return (double)sesionesAsistidas / sesionesTotales * 100;

                }
                

                public static bool CumpleMinimo(double porcentaje)
                {
                    return porcentaje >= 75;
                }
                
            }


            public string MostrarInformacion()
            {
                double porcentajeAsistencia = Asistencia.CalcularPorcentaje(SesionesAsistidas, SesionesTotales);
                bool cumpleMinimo = Asistencia.CumpleMinimo(porcentajeAsistencia);
                return $"Nombre: {Nombre}, Porcentaje de Asistencia: {porcentajeAsistencia:F2}%, ¿Cumple Mínimo?: {(cumpleMinimo ? "Sí" : "No")}";
            }
        }
    }
}