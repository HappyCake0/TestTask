using Microsoft.EntityFrameworkCore;


namespace TestTask.Data
{
    public class TestTaskContext : DbContext
    {
        public TestTaskContext (DbContextOptions<TestTaskContext> options)
            : base(options)
        {
        }

        public DbSet<TestTask.Models.Order> Order { get; set; } = default!;
    }
}
