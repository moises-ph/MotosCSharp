using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MotoStore.Models;
using System.Data.SqlClient;

namespace MotoStore.Data
{
    public class ClienteData
    {
        public static bool crearCliente(Cliente cliente)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_create_Cliente '{cliente.IdCliente}', '{cliente.NombreCliente}', '{cliente.ApellidoCliente}', '{cliente.Correo}', '{cliente.Telefono}', '{cliente.Direccion}', '{cliente.Ciudad}'";
            if(!objConexion.EjecutarSentencia(sentencia, false))
            {
                return false;
            }
            objConexion = null;
            return true;
        }

        public static bool actualizarCliente(Cliente cliente)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_Update_Cliente '{cliente.IdCliente}', '{cliente.NombreCliente}', '{cliente.ApellidoCliente}', '{cliente.Correo}', '{cliente.Telefono}', '{cliente.Direccion}', '{cliente.Ciudad}'";
            if (!objConexion.EjecutarSentencia(sentencia, false))
            {
                return false;
            }
            objConexion = null;
            return true;
        }

        public static bool eliminarCliente(string id)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_delete_cliente '{id}'";
            if(!objConexion.EjecutarSentencia(sentencia, false))
            {
                return false;
            }
            objConexion = null;
            return true;
        }

        public static List<Cliente> consultarCliente(string id)
        {
            ConexionBD objConexion = new ConexionBD();
            string sentencia = $"usp_read_cliente '{id}'";
            List<Cliente> arrCliente = new List<Cliente>();
            if (objConexion.Consultar(sentencia, false))
            {
                SqlDataReader reader = objConexion.Reader;
                reader.Read();
                arrCliente.Add(new Cliente() {
                    IdCliente = reader["IdCliente"].ToString(),
                    NombreCliente = reader["NombreCliente"].ToString(),
                    ApellidoCliente = reader["ApellidoCliente"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Direccion = reader["Direccion"].ToString(),
                    Ciudad = reader["Ciudad"].ToString()
                });
                return arrCliente;
            }
            return arrCliente;
        }

        public static List<Cliente> listarClientes()
        {
            ConexionBD objConexoin = new ConexionBD();
            string sentencia = "usp_Listar_Cliente";
            List<Cliente> arrCliente = new List<Cliente>();
            if(objConexoin.Consultar(sentencia, false))
            {
                SqlDataReader dr = objConexoin.Reader;
                while (dr.Read())
                {
                    arrCliente.Add(new Cliente()
                    {
                        IdCliente = dr["IdCliente"].ToString(),
                        NombreCliente = dr["NombreCliente"].ToString(),
                        ApellidoCliente = dr["ApellidoCliente"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Ciudad = dr["Ciudad"].ToString()
                    });
                }
                return arrCliente;
            }
            else
            {
                return arrCliente;
            }
        }
    }
}