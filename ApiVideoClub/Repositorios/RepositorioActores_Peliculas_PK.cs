using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioActores_Peliculas_PK:Repositorio<Actores_Peliculas_PKViewModel,Actores_Peliculas_PK>
    {
        public RepositorioActores_Peliculas_PK(ejercicioVideoclubEntities context) : base(context)
        {
        }
    }
}