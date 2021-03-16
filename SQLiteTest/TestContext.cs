using Microsoft.EntityFrameworkCore;

namespace SQLiteTest
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> opts)
            : base(opts)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Parent>();
            _ = modelBuilder.Entity<Child>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
