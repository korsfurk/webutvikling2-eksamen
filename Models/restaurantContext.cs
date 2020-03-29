using Microsoft.EntityFrameworkCore;

namespace EksamenApi.Models{
    public class restaurantContext : DbContext {

        public restaurantContext(DbContextOptions<restaurantContext> options):base(options){}
        public DbSet<EksamenApi.Models.restaurant> Restaurant { get; set; }
    }
}
