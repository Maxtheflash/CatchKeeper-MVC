using System.Data.Entity;

namespace CatchKeeperMVC.Models
{
    public class CatchKeeperContext : DbContext
    {
        public CatchKeeperContext()
            : base("CatchKeeperConnection")
        {
        }

        public DbSet<Catch> Catches { get; set; }
    }
}
