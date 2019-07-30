using Microsoft.EntityFrameworkCore;

namespace Frontend.Models
{
    public class FrontendContext : DbContext
    {
        public FrontendContext (DbContextOptions<FrontendContext> options)
            : base(options)
        {
        }

        public DbSet<Frontend.Models.Onigiri> Onigiri { get; set; }
    }
}
