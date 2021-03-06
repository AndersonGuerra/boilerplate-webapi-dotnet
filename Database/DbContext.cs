using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}