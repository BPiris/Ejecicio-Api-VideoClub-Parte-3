using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios.Base;

namespace ApiVideoClub.Repositorios
{
    public class RepositorioUsuario:Repositorio<UsuarioViewModel,Usuarios>
    {
        public RepositorioUsuario(ejercicioVideoclubEntities context) : base(context)
        {
        }
    }
}