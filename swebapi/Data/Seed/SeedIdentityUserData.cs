using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using swebapi.Models;

namespace swebapi.Data.Seed
{
    public static class SeedIdentityUserData
    {
        public static void SeedUserIdentityData(this ModelBuilder modelBuilder)
        {
            //Agregar el rol del "administrador" a la tabla AspNetRoles
            string AdministradorGeneralRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdministradorGeneralRoleId,
                Name = "Administrador",
                NormalizedName = "Administrador".ToUpper()
            });

            //Agregar el rol "Usuario general" a la tabla AspNetRoles
            string UsuarioGeneralRolId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = UsuarioGeneralRolId,
                Name = "Usuario General",
                NormalizedName = "Usuario general".ToUpper()
            });

            //Agregamos un usuario a la tabla AspNetUsers
            var UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId, //Primary Key
                    UserName = "gvera@uv.mx",
                    Email = "gvera@uv.mx",
                    NormalizedEmail = "gvera@uv.mx".ToUpper(),
                    Nombre = "Guillermo Hummberto Vera Amaro",
                    NormalizedUserName = "gvera@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "gverapwd")
                }
            );

            //Aplicamos la relacion entre el usuario y el rol en la tabla AspNerUserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );

            UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId, //Primary Key
                    UserName = "sperz@uv.mx",
                    Email = "sperez@uv.mx",
                    NormalizedEmail = "sperez@uv.mx".ToUpper(),
                    Nombre = "Saúl Pérez Garcia",
                    NormalizedUserName = "sperez@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "saulpwd")
                }
            );

            //Aplicamos la relacion entre el usuario y el rol en la tabla AspNerUserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );

            UsuarioId = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new CustomIdentityUser
                {
                    Id = UsuarioId, //Primary Key
                    UserName = "gochoa@uv.mx",
                    Email = "gochoa@uv.mx",
                    NormalizedEmail = "gochoa@uv.mx".ToUpper(),
                    Nombre = "Gerardo Ochoa Martinez",
                    NormalizedUserName = "gochoa@uv.mx".ToUpper(),
                    PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "gerapwd")
                }
            );

            //Aplicamos la relacion entre el usuario y el rol en la tabla AspNerUserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );
        }
    }
}
