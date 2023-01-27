using Microsoft.EntityFrameworkCore;

namespace YardStompers.Data
{
    public class YardStompersDbContext : DbContext
    {
        public YardStompersDbContext(DbContextOptions<YardStompersDbContext> options) 
            :base(options) {  }
    }
    prop
}
