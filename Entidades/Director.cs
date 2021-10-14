using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int Area { get; set; }

        public Director(string apellido, string nombre, string matricula, string especialidad, string domicilio, string email, int telefono, int area)
        {
            Apellido = apellido;
            Nombre = nombre;
            Matricula = matricula;
            Especialidad = especialidad;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
            Area = area;
        }
    }
}
