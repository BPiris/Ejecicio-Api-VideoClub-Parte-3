using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioActores:Repositorio<ActoresViewModel,Actores>
    {
        public RepositorioActores(ejercicioVideoclubEntities context) : base(context)
        {
        }

        public List<ActoresViewModel> ObtenerActoresPorPelicula(int idPelicula)
        {
            var listaIdActoresPorPelicula = new RepositorioActores_Peliculas_PK(new ejercicioVideoclubEntities()).Find(bd => bd.idPelicula == idPelicula);

            var listaActores = new List<ActoresViewModel>();

            foreach (var idActoresPorPelicula in listaIdActoresPorPelicula)
            {
                var actor = Get(idActoresPorPelicula.idActores);
                actor.SueldoActorEnPelicula = idActoresPorPelicula.Sueldo;
                listaActores.Add(actor);
            }

            return listaActores;
        }

        public override ActoresViewModel Add(ActoresViewModel model)
        {
            var actor = base.Add(model);

            if (model.idPelicula != 0)
            {
                var tablaIntermediaPK = new Actores_Peliculas_PKViewModel() { idActores = actor.idActores, idPelicula = model.idPelicula, Sueldo = model.SueldoActorEnPelicula };
                new RepositorioActores_Peliculas_PK(new ejercicioVideoclubEntities()).Add(tablaIntermediaPK);

                var tablaIntermediaIncremental = new Actores_Peliculas_IncrementalViewModel() { idActores = actor.idActores, idPeliculas = model.idPelicula, Sueldo = model.SueldoActorEnPelicula };
                new RepositorioActores_Peliculas_Incremental(new ejercicioVideoclubEntities()).Add(tablaIntermediaIncremental);
            }

            return actor;
        }

        public override ActoresViewModel Update(ActoresViewModel model)
        {

            var actor = base.Update(model);

            if (model.idPelicula != 0)
            {
                var tablaIntermediaPK = new Actores_Peliculas_PKViewModel() { idActores = actor.idActores, idPelicula = model.idPelicula, Sueldo = model.SueldoActorEnPelicula };
                new RepositorioActores_Peliculas_PK(new ejercicioVideoclubEntities()).Update(tablaIntermediaPK);

                var tablaIntermediaIncremental = new Actores_Peliculas_IncrementalViewModel() { idActores = actor.idActores, idPeliculas = model.idPelicula, Sueldo = model.SueldoActorEnPelicula };
                new RepositorioActores_Peliculas_Incremental(new ejercicioVideoclubEntities()).Update(tablaIntermediaIncremental);
            }

            return actor;
        }


    }
}