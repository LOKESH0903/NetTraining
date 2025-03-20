using System.Data.Entity;

namespace Training
{
    public class EFDBConsoleApplication : DbContext
    {
        public EFDBConsoleApplication() : base("dbconnection")
        {
        }
        public DbSet<Students> Students { get; set; }
    }
}
