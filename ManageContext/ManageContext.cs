using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

namespace Fluent_API_hw
{
    public class ManageContext: DbContext
    {
       public virtual DbSet<Worker> Workers { get; set; }
       public virtual DbSet<Position> Positions { get; set; }
       public virtual DbSet<Users> Users { get; set; }




        public ManageContext(DbContextOptions<ManageContext> options) : base(options) { }
        public ManageContext() { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>()
                .HasOne(w => w.Position)
                .WithMany(p => p.Workers)
                .HasForeignKey(w => w.PositionId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();



                string connection = config.GetConnectionString("DefaultConnection");

                optionsBuilder.UseSqlite(connection);
            }
        }

    }
}
