using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class ActoresViewModel:IViewModel<Actores>
    {
        public int idActores { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        //Externa al modelo
        public int SueldoActorEnPelicula { get; set; }

        //Necesaria para el uso de MVC
        public int idPelicula { get; set; }

        public Actores ToModel()
        {
            return new Actores()
            {
                idActores = idActores,
                nombre = nombre,
                apellidos = apellidos
            };
        }

        public void FromModel(Actores model)
        {
            idActores = model.idActores;
            nombre = model.nombre;
            apellidos = model.apellidos;
        }

        public void UpdateModel(Actores model)
        {
            model.idActores = idActores;
            model.nombre = nombre;
            model.apellidos = apellidos;
        }

        public int[] GetPk()
        {
            return new[] {idActores};
        }
    }
}