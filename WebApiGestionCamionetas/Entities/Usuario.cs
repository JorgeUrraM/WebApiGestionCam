using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGestionCamionetas.Entities
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LicenciaInterna { get; set; }
        public bool LicenciaMunicipal { get; set; }
    }
}
