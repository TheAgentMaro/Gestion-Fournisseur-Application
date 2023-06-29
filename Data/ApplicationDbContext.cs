using GestionFournisseur.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionFournisseur.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
