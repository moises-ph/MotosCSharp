using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoStore.Models
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
    }
}