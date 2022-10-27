using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MotoStore.Data;
using MotoStore.Models;

namespace MotoStore.Controllers
{
    public class MotoController : ApiController
    {
        // GET api/<controller>
        public List<Moto> Get()
        {
            return MotoData.listarMotos();
        }

        // GET api/<controller>/5
        public List<Moto> Get(string id)
        {
            return MotoData.consultarMoto(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Moto oMoto)
        {
            return MotoData.crearMoto(oMoto);
        }
    }
}