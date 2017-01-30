using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios;
using Microsoft.Practices.Unity;

namespace ApiVideoClub.Controllers
{
    public class ClientesController : ApiController
    {
        [Dependency]
        public RepositorioClientes _RepoClientes { get; set; }

        // GET: api/Clientes
        public IEnumerable<ClientesViewModel> Get()
        {
            return _RepoClientes.Get();
        }

        // GET: api/Clientes/5
        public ClientesViewModel Get(int id)
        {
            return _RepoClientes.Get(id);
        }

        // POST: api/Clientes
        public void Post([FromBody]ClientesViewModel añadirCliente)
        {
            _RepoClientes.Add(añadirCliente);
        }

        // PUT: api/Clientes/5
        public void Put([FromBody]ClientesViewModel actualizarClientes)
        {
            _RepoClientes.Update(actualizarClientes);
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
            _RepoClientes.Delete(id);
        }
    }
}
