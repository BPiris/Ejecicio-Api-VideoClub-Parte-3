using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class ClientesViewModel:IViewModel<Clientes>
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidosCliente { get; set; }

        //Externas al Modelo
        public List<PeliculasViewModel> PeliculasCliente { get; set; }

        public Clientes ToModel()
        {
            return new Clientes()
            {
                idCliente = idCliente,
                nombreCliente = nombreCliente,
                apellidosCliente = apellidosCliente
            };
        }

        public void FromModel(Clientes model)
        {
            idCliente = model.idCliente;
            nombreCliente = model.nombreCliente;
            apellidosCliente = model.apellidosCliente;

            try
            {
                var temp = new List<PeliculasViewModel>();
                foreach (var pelicula in model.Peliculas)
                {
                    var temp1 = new PeliculasViewModel();
                    temp1.FromModel(pelicula);
                    temp.Add(temp1);
                }
                PeliculasCliente = temp;
            }
            catch (Exception)
            {
                PeliculasCliente = null;
            }
        }

        public void UpdateModel(Clientes model)
        {
            model.idCliente = idCliente;
            model.nombreCliente = nombreCliente;
            model.apellidosCliente = apellidosCliente;
        }

        public int[] GetPk()
        {
            return new[] {idCliente};
        }
    }
}