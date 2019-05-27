using Microsoft.EntityFrameworkCore;
using NileMoster.WebApi.Models;

namespace NileMoster.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options){}

        public DbSet<Values> Values {get; set;}
    }
}