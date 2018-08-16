using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Certificado.Modelos
{
    public class Usuarios
    {
        private string nombre;
        private string apellidos;
        private string telefono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}