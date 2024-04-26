using Microsoft.EntityFrameworkCore;
using InformationsMVC.Models;

namespace InformationsMVC.Data
{
    public class InformationsMVCContext : DbContext
    {
        public InformationsMVCContext(DbContextOptions<InformationsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<InformationsMVC.Models.User> User { get; set; } = default!;
        public DbSet<InformationsMVC.Models.Brand> Brand { get; set; } = default!;
        public DbSet<InformationsMVC.Models.Category> Category { get; set; } = default!;
        public DbSet<InformationsMVC.Models.Customer> Customer { get; set; } = default!;
    }
}
