using System.Text;
using System.Threading.Tasks;
using static Trabajo4.Universidad.Estudiante;

namespace Trabajo4
{
    public static class ExtensionesEstudiante
    {
        public static void MostrarInformacion(this Universidad.Estudiante estudiante)
        {

            double porcentajeAsistencia = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.SesionesAsistidas, estudiante.SesionesTotales);

            bool cumpleMinimo = Universidad.Estudiante.Asistencia.CumpleMinimo(porcentajeAsistencia);


            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Total de sesiones: {estudiante.SesionesTotales}");
            Console.WriteLine($"Sesiones asistidas: {estudiante.SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de asistencia: {porcentajeAsistencia:F2}%");
            Console.WriteLine(cumpleMinimo ? "Cumple con el mínimo de asistencia." : "No cumple con el mínimo de asistencia.");
            Console.WriteLine();
        }
    }
}