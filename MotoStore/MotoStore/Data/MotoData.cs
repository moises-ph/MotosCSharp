using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MotoStore.Data;
using MotoStore.Models;

namespace MotoStore.Data
{
    public class MotoData
    {
        public static bool crearMoto(Moto moto)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_create_Moto '{moto.Marca}', '{moto.Modelo}', {moto.Cilindraje}";
        }
    }
}