using Microsoft.EntityFrameworkCore;

namespace ContactPage.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entry> Entries { get; set; }
    }
}
