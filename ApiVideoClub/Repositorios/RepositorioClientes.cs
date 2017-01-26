using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioClientes:Repositorio<ClientesViewModel, Clientes>
    {
        public RepositorioClientes(ejercicioVideoclubEntities context) : base(context)
        {
        }
    }
}