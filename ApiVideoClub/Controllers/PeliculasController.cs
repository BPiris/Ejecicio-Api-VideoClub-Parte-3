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
    public class PeliculasController : ApiController
    {
        [Dependency]
        public RepositorioPeliculas _repoPelis { get; set; }

        [Dependency]
        public RepositorioActores _RepoActores { get; set; }

        // GET: api/Peliculas
        public IEnumerable<PeliculasViewModel> Get()
        {
            return _repoPelis.Get();
        }

        // GET: api/Peliculas/5
        public PeliculasViewModel Get(int id)
        {
            var pelicula = _repoPelis.Get(id);
            pelicula.ActoresPelicula = _RepoActores.ObtenerActoresPorPelicula(pelicula.idPelicula);

            return pelicula;
        }

        // POST: api/Peliculas
        public void Post([FromBody]PeliculasViewModel value)
        {
            _repoPelis.Add(value);
        }

        // PUT: api/Peliculas/5
        public void Put(int id, [FromBody]PeliculasViewModel value)
        {
            _repoPelis.Update(value);
        }

        // DELETE: api/Peliculas/5
        public void Delete(int id)
        {
            _repoPelis.Delete(id);
        }

        [HttpGet]
        public List<PeliculasViewModel> BuscarPeliculas(String busqueda)
        {
            return _repoPelis.Find(bd => bd.nombrePelicula.ToLower().Contains(busqueda.ToLower()));
        }
    }
}
