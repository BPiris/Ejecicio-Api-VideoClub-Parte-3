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
    public class ActoresController : ApiController
    {
        [Dependency]
        public RepositorioPeliculas _repoPelis { get; set; }

        [Dependency]
        public RepositorioActores _RepoActores { get; set; }

        // GET: api/Actores
        public IEnumerable<ActoresViewModel> Get()
        {
            return _RepoActores.Get();
        }

        // GET: api/Actores/5
        public ActoresViewModel Get(int id)
        {
            return _RepoActores.Get(id);
        }

        // POST: api/Actores
        public void Post([FromBody]ActoresViewModel value)
        {
            _RepoActores.Add(value);
        }

        // PUT: api/Actores/5
        public void Put(int id, [FromBody]ActoresViewModel value)
        {
            _RepoActores.Update(value);
        }

        // DELETE: api/Actores/5
        public void Delete(int id)
        {
            _RepoActores.Delete(id);
        }

        [HttpGet]
        public List<ActoresViewModel> BuscarActores(String busqueda)
        {
            return _RepoActores.Find(bd => bd.nombre.ToLower().Contains(busqueda.ToLower()) || bd.apellidos.ToLower().Contains(busqueda.ToLower()));
        }
    }
}
