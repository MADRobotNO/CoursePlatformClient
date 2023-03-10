using CoursePlatformClient.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatformClient.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}