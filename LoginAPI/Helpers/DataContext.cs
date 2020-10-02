using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LoginAPI.Entities;

namespace LoginAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("LoginAPIDatabase"));
        }

        public DbSet<User> Users { get; set; }
    }
}
