using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Config;

public class MySQLDBContext : DbContext
{
    public DbSet<User> User { get; set; }
    
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options)
    {
    }
}