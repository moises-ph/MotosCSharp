using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MotoStore.Data;
using MotoStore.Models;

namespace MotoStore.Controllers
{
    public class ClienteController : ApiController
    {
        // GET api/<controller>
        public List<Cliente> Get()
        {
            return ClienteData.listarClientes();
        }

        // GET api/<controller>/5
        public List<Cliente> Get(string id)
        {
            return ClienteData.consultarCliente(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Cliente oCliente)
        {
            return ClienteData.crearCliente(oCliente);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Cliente oCliente)
        {
            return ClienteData.actualizarCliente(oCliente);
        }

        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ClienteData.eliminarCliente(id);
        }
    }
}