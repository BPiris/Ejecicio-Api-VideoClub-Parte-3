using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class Actores_Peliculas_IncrementalViewModel:IViewModel<Actores_Peliculas_Incremental>
    {
        public int idActores_Peliculas { get; set; }
        public int idActores { get; set; }
        public int idPeliculas { get; set; }
        public int Sueldo { get; set; }

        public Actores_Peliculas_Incremental ToModel()
        {
            return new Actores_Peliculas_Incremental()
            {
                idActores_Peliculas = idActores_Peliculas,
                idActores = idActores,
                idPeliculas = idPeliculas,
                Sueldo = Sueldo
            };
        }

        public void FromModel(Actores_Peliculas_Incremental model)
        {
            idActores_Peliculas = model.idActores_Peliculas;
            idActores = model.idActores;
            idPeliculas = model.idPeliculas;
            Sueldo = model.Sueldo;            
        }

        public void UpdateModel(Actores_Peliculas_Incremental model)
        {
            model.idActores_Peliculas = idActores_Peliculas;
            model.idActores = idActores;
            model.idPeliculas = idPeliculas;
            model.Sueldo = Sueldo;
        }

        public int[] GetPk()
        {
            return new[] {idActores_Peliculas};
        }
    }
}