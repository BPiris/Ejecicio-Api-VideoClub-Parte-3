using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios;
using Microsoft.Practices.Unity;

namespace ApiVideoClub.Controllers
{
    public class UsuariosController : ApiController
    {
        [Dependency]
        public RepositorioUsuario _Usuarios { get; set; }

        [HttpGet]
        public List<UsuarioViewModel> ComprobarUsuario(String username, String password)
        {
            return _Usuarios.Find(bd => bd.nombreUsuario == username && bd.passwordUsuario == password);
        }
    }
}
