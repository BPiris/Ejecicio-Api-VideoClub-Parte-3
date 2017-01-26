using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioPeliculas:Repositorio<PeliculasViewModel,Peliculas>
    {
        public RepositorioPeliculas(ejercicioVideoclubEntities context) : base(context)
        {
        }

        public List<PeliculasViewModel> ObtenerPeliculasPorActor(int idActores)
        {
            var listaIdPeliculasPorActor = new RepositorioActores_Peliculas_Incremental(new ejercicioVideoclubEntities()).Find(bd => bd.idActores == idActores);
            var listaPeliculas = new List<PeliculasViewModel>();
            foreach (var idPeliculaPorActor in listaIdPeliculasPorActor)
            {
                var pelicula = Get(idPeliculaPorActor.idActores);
                listaPeliculas.Add(pelicula);
            }
            return listaPeliculas;
        }
    }
}