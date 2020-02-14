using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGestionCamionetas.Entities;

namespace WebApiGestionCamionetas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<DescFatiga> DescFatiga { get; set; }
        public DbSet<DescSomnolencia> DescSomnolencia { get; set; }
        public DbSet<DescEstadoCamioneta> DescEstadoCamioneta { get; set; }


    }
}
