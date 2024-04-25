using Microsoft.EntityFrameworkCore;

namespace InformationsMVC.Data
{
    public class InformationsMVCContext : DbContext
    {
        public InformationsMVCContext(DbContextOptions<InformationsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<InformationsMVC.Models.User> User { get; set; } = default!;
    }
}
