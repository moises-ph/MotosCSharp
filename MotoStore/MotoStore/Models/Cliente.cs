using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoStore.Models
{
    public class Cliente
    {
        public string IdCliente { get => IdCliente; set => IdCliente = value; }
        public string NombreCliente { get => NombreCliente; set => NombreCliente = value; }
        public string ApellidoCliente { get => ApellidoCliente; set => ApellidoCliente = value; }
        public string Correo { get => Correo; set => Correo = value; }
        public string Telefono { get => Telefono; set => Telefono = value; }
        public string Direccion { get => Direccion; set => Direccion = value; }
        public string Ciudad { get => Ciudad; set => Ciudad = value; }
    }
}