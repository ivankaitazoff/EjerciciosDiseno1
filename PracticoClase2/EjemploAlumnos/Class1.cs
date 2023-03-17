using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAlumnos
{
    public class Alumno
    {
        public int numero { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public int CalcularEdadA(DateTime fecha)
        {
            var edad = fecha.Year - this.fechaNacimiento.Year;
            
            if(fechaNacimiento.Date > fecha.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }
}
