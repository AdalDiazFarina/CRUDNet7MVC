using CrudNet7MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace CrudNet7MVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

        // Agregar los modelos aquí
        public DbSet<Contacto> Contactos { get; set; }
    }
}
