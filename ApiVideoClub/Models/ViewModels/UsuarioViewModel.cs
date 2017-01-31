using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiVideoClub.Models.ViewModels.Base;

namespace ApiVideoClub.Models.ViewModels
{
    public class UsuarioViewModel:IViewModel<Usuarios>
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string passwordUsuario { get; set; }

        public Usuarios ToModel()
        {
            return new Usuarios()
            {
                idUsuario = idUsuario,
                nombreUsuario = nombreUsuario,
                passwordUsuario = passwordUsuario
            };
        }

        public void FromModel(Usuarios model)
        {
            idUsuario = model.idUsuario;
            nombreUsuario = model.nombreUsuario;
            passwordUsuario = model.passwordUsuario;
        }

        public void UpdateModel(Usuarios model)
        {
            model.idUsuario = idUsuario;
            model.nombreUsuario = nombreUsuario;
            model.passwordUsuario = passwordUsuario;
        }

        public int[] GetPk()
        {
            return new[] {idUsuario};
        }
    }
}