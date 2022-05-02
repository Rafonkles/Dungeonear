using Microsoft.EntityFrameworkCore;

namespace DungeonEarAPI.Database {
    public class DungeonEarDatabaseContext : DbContext {

        public DungeonEarDatabaseContext(DbContextOptions opt) : base(opt) {

            

        }

        public DbSet<DbLocation> Locations { get; set; }

        public DbSet<DbExits> Exits { get; set; }

        public DbSet<DbLoginDetail> LoginDetails { get; set; }


    }
}
