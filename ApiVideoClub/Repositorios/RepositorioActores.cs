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
                listaActores.Add(actor);
            }

            return listaActores;
        }
    }
}