using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COAChallenge.NETCore.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo Username es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Username es demasiado largo.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo Nombre es demasiado largo.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email no valido. Reintente.")]
        public string Email { get; set; }

        [StringLength(10, MinimumLength = 7, ErrorMessage = "El campo telefono no cumple con la cantidad de caracteres requeridos")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string Telefono { get; set; }
    }
}
