using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoStore.Models
{
    public class Moto
    {
        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindraje { get; set; }
        public string Freno { get; set; }
        public string Llantas { get; set; }
        public string Refirigeracion { get; set; }
        public string Suspension { get; set; }
        public Double ValorMoto { get; set; }
        public Double ValorSoat { get; set; }
        public Double ValorTotal { get; set; }
        public string IdCliente { get; set; }
    }
}