using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGestionCamionetas.Entities
{
    public class DescEstadoCamioneta
    {
        [Key]
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

    }
}
