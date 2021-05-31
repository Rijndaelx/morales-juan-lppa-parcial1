using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace morales_juan_lppa_parcial1.Data.Entities
{
    public class Afiliado : IdentityBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public string Telefono { get; set; }

        [RegularExpression("^\\d{2}\\-\\d{8}\\-\\d{1}$", ErrorMessage = "CUIT Inválido")]
        public string CUIT { get; set; }

    }
}