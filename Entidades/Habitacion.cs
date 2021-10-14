using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        
        public Habitacion(string nombre, string estado)
        {
            Nombre = nombre;
            Estado = estado;
        }
    }
}
