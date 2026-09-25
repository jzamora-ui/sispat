using System.ComponentModel.DataAnnotations;

namespace SiPat.Models.LoginViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El usuario es obligatorio.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El usuario debe tener exactamente 8 caracteres.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "La contraseña debe tener exactamente 8 caracteres.")]
        public string Contrasena { get; set; }
    }
}
