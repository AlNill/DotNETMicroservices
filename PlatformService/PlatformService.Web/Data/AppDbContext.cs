using Microsoft.EntityFrameworkCore;
using PlatformService.Web.Models;

namespace PlatformService.Web.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
    {
       
    }

    public DbSet<Platform> Platforms { get; set; }
}
