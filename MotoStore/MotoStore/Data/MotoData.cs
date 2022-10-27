using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MotoStore.Data;
using MotoStore.Models;
using System.Data.SqlClient;

namespace MotoStore.Data
{
    public class MotoData
    {
        public static bool crearMoto(Moto moto)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_create_Moto '{moto.Marca}', '{moto.Modelo}', {moto.Cilindraje}, '{moto.Freno}', '{moto.Llantas}', '{moto.Refirigeracion}', '{moto.Suspension}', {moto.ValorMoto}, {moto.ValorSoat}, {moto.ValorTotal} , '{moto.IdCliente}'";
            if(!objConexion.EjecutarSentencia(sentencia, false))
            {
                return false;
            }
            objConexion = null;
            return true;
        }

        public static List<Moto> consultarMoto(string id)
        {
            ConexionBD objConexion = new ConexionBD();
            List<Moto> consultas = new List<Moto>();
            string sentencia = $"usp_read_Moto {id}";
            if(objConexion.Consultar(sentencia, false))
            {
                SqlDataReader dr = objConexion.Reader;
                while (dr.Read())
                {
                    consultas.Add(new Moto()
                    {
                        IdCompra = (int)dr["IdCompra"],
                        FechaCompra = DateTime.Parse(dr["FechaCompra"].ToString()),
                        Marca = dr["Marca"].ToString(),
                        Modelo = dr["Modelo"].ToString(),
                        Cilindraje = (int)dr["Cilindraje"],
                        Freno = dr["Freno"].ToString(),
                        Llantas = dr["Llantas"].ToString(),
                        Refirigeracion = dr["Regrigeracion"].ToString(),
                        Suspension = dr["Suspension"].ToString(),
                        ValorMoto = (int)dr["ValorMoto"],
                        ValorSoat = (int)dr["ValorSoat"],
                        ValorTotal = (int)dr["ValorTotal"],
                        IdCliente = dr["IdCliente"].ToString()
                    });
                }
                return consultas;
            }
            else
            {
                return consultas;
            }
        }

        public static List<Moto> listarMotos()
        {
            ConexionBD objConexion = new ConexionBD();
            List<Moto> consultas = new List<Moto>();
            string sentencia = $"usp_Listar_Moto";
            if (objConexion.Consultar(sentencia, false))
            {
                SqlDataReader dr = objConexion.Reader;
                while (dr.Read())
                {
                    consultas.Add(new Moto()
                    {
                        IdCompra = (int)dr["IdCompra"],
                        FechaCompra = DateTime.Parse(dr["FechaCompra"].ToString()),
                        Marca = dr["Marca"].ToString(),
                        Modelo = dr["Modelo"].ToString(),
                        Cilindraje = (int)dr["Cilindraje"],
                        Freno = dr["Freno"].ToString(),
                        Llantas = dr["Llantas"].ToString(),
                        Refirigeracion = dr["Regrigeracion"].ToString(),
                        Suspension = dr["Suspension"].ToString(),
                        ValorMoto = (int)dr["ValorMoto"],
                        ValorSoat = (int)dr["ValorSoat"],
                        ValorTotal = (int)dr["valorTotal"],
                        IdCliente = dr["IdCliente"].ToString()
                    });
                }
                return consultas;
            }
            else
            {
                return consultas;
            }
        }
    }
}