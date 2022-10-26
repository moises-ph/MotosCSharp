using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoStore.Models
{
    public class Moto
    {
        public int IdCompra { get => IdCompra; set => IdCompra = value; }
        public DateTime FechaCompra { get => FechaCompra; set => FechaCompra = value; }
        public string Marca { get => Marca; set => Marca = value; }
        public string Modelo { get => Modelo; set => Modelo = value; }
        public int Cilindraje { get => Cilindraje; set => Cilindraje = value; }
        public string Freno { get => Freno; set => Freno = value; }
        public string Llantas { get => Llantas; set => Llantas = value; }
        public string Refirigeracion { get => Refirigeracion; set => Refirigeracion = value; }
        public string Suspension { get => Suspension; set => Suspension = value; }
        public Double ValorMoto { get => ValorMoto; set => ValorMoto = value; }
        public Double ValorSoat { get => ValorSoat; set => ValorSoat = value; }
        public Double ValorTotal { get => ValorTotal; set => ValorTotal = value; }
        public string IdCliente { get => IdCliente; set => IdCliente = value; }
    }
}