using DateApp5.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DateApp5.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
            
        public DbSet<Value> Values  { get; set; }
    }
}