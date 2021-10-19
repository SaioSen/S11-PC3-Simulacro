using System;
using Microsoft.EntityFrameworkCore;


namespace S11_PC3_Simulacro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {}

        public DbSet<S11_PC3_Simulacro.Models.Producto> DataProductos { get; set; }

        public DbSet<S11_PC3_Simulacro.Models.Producto> DataCategoria { get; set; }




    }
}