﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Reportex.Models
{
    public partial class Rol
    {
        public Rol()
        {
            RolMenu = new HashSet<RolMenu>();
            RolReporte = new HashSet<RolReporte>();
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public int RolId { get; set; }
        public string Denominacion { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<RolMenu> RolMenu { get; set; }
        public virtual ICollection<RolReporte> RolReporte { get; set; }
        public virtual ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}