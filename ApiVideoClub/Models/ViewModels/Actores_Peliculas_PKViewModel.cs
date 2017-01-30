using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class Actores_Peliculas_PKViewModel:IViewModel<Actores_Peliculas_PK>
    {
        public int idActores { get; set; }
        public int idPelicula { get; set; }
        public int Sueldo { get; set; }

        public Actores_Peliculas_PK ToModel()
        {
            return new Actores_Peliculas_PK()
            {
                idActores = idActores,
                idPelicula = idPelicula,
                Sueldo = Sueldo
            };
        }

        public void FromModel(Actores_Peliculas_PK model)
        {
            idActores = model.idActores;
            idPelicula = model.idPelicula;
            Sueldo = model.Sueldo;            
        }

        public void UpdateModel(Actores_Peliculas_PK model)
        {
            model.idActores = idActores;
            model.idPelicula = idPelicula;
            model.Sueldo = Sueldo;
        }

        public int[] GetPk()
        {
            return new[] {idActores, idPelicula};
        }
    }
}