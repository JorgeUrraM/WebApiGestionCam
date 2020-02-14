using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGestionCamionetas.Entities
{
    public class DescFatiga
    {
        [Key]
        public int IdFatiga { get; set; }
        public string Descripcion { get; set; }
    }
}
