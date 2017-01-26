using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class PeliculasViewModel:IViewModel<Peliculas>
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public int anoPelicula { get; set; }
        public string formatoPelicula { get; set; }
        public string Descripcion { get; set; }
        public int idCliente { get; set; }

        //Externas al modelo
        public List<ActoresViewModel> ActoresPelicula { get; set; }

        public Peliculas ToModel()
        {
            return new Peliculas()
            {
                idPelicula = idPelicula,
                nombrePelicula = nombrePelicula,
                anoPelicula = anoPelicula,
                formatoPelicula = formatoPelicula,
                Descripcion = Descripcion,
                idCliente = idCliente
            };
        }

        public void FromModel(Peliculas model)
        {
            idPelicula = model.idPelicula;
            nombrePelicula = model.nombrePelicula;
            anoPelicula = model.anoPelicula;
            formatoPelicula = model.formatoPelicula;
            Descripcion = model.Descripcion;
            idCliente = model.idCliente;
        }

        public void UpdateModel(Peliculas model)
        {
            model.idPelicula = idPelicula;
            model.nombrePelicula = nombrePelicula;
            model.anoPelicula = anoPelicula;
            model.formatoPelicula = formatoPelicula;
            model.Descripcion = Descripcion;
            model.idCliente = idCliente;
        }

        public int[] GetPk()
        {
            return new[] {idPelicula};
        }
    }
}