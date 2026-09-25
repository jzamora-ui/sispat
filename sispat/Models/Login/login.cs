using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiPat.Models.Login
{
    public class login
    {
        [Required(ErrorMessage = "El usuario es obligatorio.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El usuario debe tener exactamente 8 caracteres.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "La contraseña debe tener exactamente 8 caracteres.")]
        public string Contrasena { get; set; }
    }
}