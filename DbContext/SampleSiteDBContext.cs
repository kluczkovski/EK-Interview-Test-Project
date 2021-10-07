namespace SampleSite.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using SampleSite.Models.Entities;

    public class SampleSiteDBContext : DbContext
    {
        public SampleSiteDBContext(DbContextOptions<SampleSiteDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
