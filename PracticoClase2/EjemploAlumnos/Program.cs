using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno unAlumno = new Alumno()
            {
                numero = 123456,
                nombres = "Juan",
                apellidos = "Perez",
                fechaNacimiento = new DateTime(2000, 12, 15)
            };
            

            Console.WriteLine(
                string.Format("{0} - {1}, {2}", 
                unAlumno.numero, unAlumno.nombres, unAlumno.apellidos));

            Console.WriteLine("Edad: {0}", unAlumno.CalcularEdadA(DateTime.Now));

            Console.ReadLine();

        }
    }
}
