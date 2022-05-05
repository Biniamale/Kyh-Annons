using Kyh_Annons.Models;
using Microsoft.EntityFrameworkCore;

namespace Kyh_Annons.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public virtual DbSet<Annons> Annons { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
