using Microsoft.EntityFrameworkCore;
using Odata.Models;

namespace Odata.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<DemoModel> Demos { get; set; }
}