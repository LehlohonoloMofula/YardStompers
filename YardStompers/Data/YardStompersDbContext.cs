using Microsoft.EntityFrameworkCore;
using YardStompers.Models;

namespace YardStompers.Data
{
    public class YardStompersDbContext : DbContext
    {
        public YardStompersDbContext(DbContextOptions<YardStompersDbContext> options) 
            :base(options) {  }


        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }
    }
    
}
