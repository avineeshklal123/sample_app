using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using sample_app.Models.Domain;

namespace sample_app.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Userdata> User_data { get; set; } 
    }

}
  