﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }

        public Clinica(string nombre, string domicilio, string email, int telefono)
        {
            Nombre = nombre;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
