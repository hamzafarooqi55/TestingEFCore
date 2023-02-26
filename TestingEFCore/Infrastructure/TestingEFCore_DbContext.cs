using Microsoft.EntityFrameworkCore;
using TestingEFCore.Model;

namespace TestingEFCore.Infrastructure
{
    public class TestingEFCore_DbContext : DbContext
    {
        public TestingEFCore_DbContext(DbContextOptions<TestingEFCore_DbContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
