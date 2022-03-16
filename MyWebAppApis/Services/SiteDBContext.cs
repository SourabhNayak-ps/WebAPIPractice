using Microsoft.EntityFrameworkCore;
using MyWebAppApis.Models;

namespace MyWebAppApis.Services
{
    public class SiteDBContext:DbContext
    {
        public SiteDBContext(DbContextOptions<SiteDBContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
