using Microsoft.EntityFrameworkCore;
using vega.Domain;

namespace vega.Database
{
    public class VegaDbContext: DbContext
    {
        public DbSet<Make> Makes { get; set; }

        public DbSet<Feature> Features { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> context)
            :base(context)
        {

        }
    }
}