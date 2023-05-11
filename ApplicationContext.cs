using System.Data.Entity;

namespace task_tracking
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
