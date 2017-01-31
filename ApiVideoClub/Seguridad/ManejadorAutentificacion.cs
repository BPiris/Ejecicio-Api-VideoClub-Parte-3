using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using ApiVideoClub.Models.ViewModels;
using ApiVideoClub.Repositorios;

namespace ApiVideoClub.Seguridad
{
    public class ManejadorAutentificacion : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response;

            if (request.Headers.Authorization != null && request.Headers.Authorization.Scheme == "Basic")
            {
                var datos = request.Headers.Authorization.Parameter.Trim();
                var uspass = Encoding.Default.GetString(Convert.FromBase64String(datos));
                var user = uspass.Split(':')[0];
                var pwd = uspass.Split(':')[1];

                var principal = Autenticar(user, pwd);

                if (principal != null)
                {
                    request.GetRequestContext().Principal = principal;
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.Unauthorized);
                    response.Headers.Add("www-Authenticate", "Basic");
                    return response;
                }
            }
            else
            {
                response = request.CreateResponse(HttpStatusCode.Unauthorized);
                response.Headers.Add("www-Authenticate", "Basic");
                return response;
            }

            response = await base.SendAsync(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
                response.Headers.Add("www-Authenticate", "Basic");

            return response;
        }

        private GenericPrincipal Autenticar(String usuario, String password)
        {
            var _Usuarios = new ejercicioVideoclubEntities();

            var usTemp = _Usuarios.Usuarios.Where(bd => bd.nombreUsuario == usuario && bd.passwordUsuario == password).ToList();

            if (usTemp.Count > 0)
            {
                IIdentity identity = new GenericIdentity(usuario);
                var principal = new GenericPrincipal(identity, new[] { usTemp[0].passwordUsuario});               

                return principal;
            }
        
            return null;
        }
}
}