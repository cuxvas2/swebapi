using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using swebapi.Data.Seed;
using swebapi.Models;

namespace swebapi.Data
{
    public class IdentityContext : IdentityDbContext<CustomIdentityUser>
    {
        //constructor de la clase
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) 
        { 
        }

        //Este DbSet nos permitirá acceder a los usuarios en los controladores
        public DbSet<CustomIdentityUser> CustomIdentityUsers { get; set; }

        //Esta funcion se llama al aplicar una migración
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Vamos a agregar 3 usuarios al momento de crear la base de datos
            modelBuilder.SeedUserIdentityData();
        }
    }
}
