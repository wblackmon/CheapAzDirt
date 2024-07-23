using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public class StoreContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public StoreContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //options.UseSqlServer(_configuration.GetConnectionString("SQLServerConnection"));
        options.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
    }
    public DbSet<Product> Products { get; set; }
}
