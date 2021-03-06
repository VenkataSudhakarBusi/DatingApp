using Microsoft.EntityFrameworkCore;
using DatingApp.Model;

namespace DatingApp.Data
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)  : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}