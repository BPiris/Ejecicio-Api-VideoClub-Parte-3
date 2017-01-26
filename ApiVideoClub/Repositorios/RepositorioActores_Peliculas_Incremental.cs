using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioActores_Peliculas_Incremental:Repositorio<Actores_Peliculas_IncrementalViewModel, Actores_Peliculas_Incremental>
    {
        public RepositorioActores_Peliculas_Incremental(ejercicioVideoclubEntities context) : base(context)
        {
        }
    }
}