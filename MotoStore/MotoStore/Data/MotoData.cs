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
        public static List<OutPutModel> crearMoto(Moto moto)
        {
            ConexionBD objConexion = new ConexionBD();
            List<OutPutModel> list = new List<OutPutModel>();
            string sentencia = $"usp_create_Moto '{moto.Marca}', '{moto.Modelo}', {moto.Cilindraje}, '{moto.Freno}', '{moto.Llantas}', '{moto.Refrigeracion}', '{moto.Suspension}', {moto.ValorMoto}, {moto.ValorSoat}, {moto.valorTotal} , '{moto.IdCliente}'";
            if(!objConexion.EjecutarSentencia(sentencia, false))
            {
                list.Add(new OutPutModel()
                {
                    Error = true,
                    Message = objConexion.Error
                });
                return list;
            }
            else
            {
                objConexion = null;
                list.Add(new OutPutModel()
                {
                    Error = false,
                    Message = ""
                });
                return list;
            }
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
                        IdCompra = Convert.ToInt32(dr["IdCompra"]),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString()),
                        Marca = dr["Marca"].ToString(),
                        Modelo = dr["Modelo"].ToString(),
                        Cilindraje = Convert.ToInt32(dr["Cilindraje"]),
                        Freno = dr["Freno"].ToString(),
                        Llantas = dr["Llantas"].ToString(),
                        Refrigeracion = dr["Refrigeracion"].ToString(),
                        Suspension = dr["Suspension"].ToString(),
                        ValorMoto = Convert.ToInt32(dr["ValorMoto"]),
                        ValorSoat = Convert.ToInt32(dr["ValorSoat"]),
                        valorTotal = Convert.ToInt32(dr["ValorTotal"]),
                        IdCliente = dr["Cliente"].ToString()
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
                        IdCompra = Convert.ToInt32(dr["IdCompra"]),
                        FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString()),
                        Marca = dr["Marca"].ToString(),
                        Modelo = dr["Modelo"].ToString(),
                        Cilindraje = Convert.ToInt32(dr["Cilindraje"]),
                        Freno = dr["Freno"].ToString(),
                        Llantas = dr["Llantas"].ToString(),
                        Refrigeracion = dr["Refrigeracion"].ToString(),
                        Suspension = dr["Suspension"].ToString(),
                        ValorMoto = Convert.ToInt32(dr["ValorMoto"]),
                        ValorSoat = Convert.ToInt32(dr["ValorSoat"]),
                        valorTotal = Convert.ToInt32(dr["ValorTotal"]),
                        IdCliente = dr["Cliente"].ToString()
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