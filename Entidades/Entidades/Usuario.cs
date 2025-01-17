﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public int IdRol { get; set; }

        public string DescripcionRol { get; set; }

        [Display(Name = "Email")]
        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        
        public int Password { get; set; }

        public int PasswordSalt { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int Activo { get; set; }

        public string RazonSocial { get; set; }

        public List<Cliente> clientes { get; set; }

    }
}
