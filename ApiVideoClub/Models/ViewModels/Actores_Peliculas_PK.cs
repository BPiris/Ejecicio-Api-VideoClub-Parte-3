//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiVideoClub.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actores_Peliculas_PK
    {
        public int idActores { get; set; }
        public int idPelicula { get; set; }
        public int Sueldo { get; set; }
    
        public virtual Actores Actores { get; set; }
        public virtual Peliculas Peliculas { get; set; }
    }
}
