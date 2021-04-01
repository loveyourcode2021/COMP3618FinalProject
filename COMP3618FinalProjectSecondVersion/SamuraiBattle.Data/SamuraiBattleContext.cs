using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SamuraiBattle.Domain;

namespace SamuraiBattle.Data
{
    public class SamuraiBattleContext:DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = ; Database = SamuraiBattleGroupProject; Trusted_Connection = True; ");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");
            modelBuilder.Entity<Samurai>(entity =>
            {
                entity.ToTable("Samurai", "SamuraiBattle");

                entity.HasComment("Samurai information.");


                entity.Property(x => x.SamuraiID)
                        .HasColumnName("SamuraiID")

                        .HasComment("Primary key for Customer records.");

                entity.Property(e => e.Picture)
                        .HasMaxLength(255)
                        .HasComment("Picture");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasComment("Name");

                entity.Property(e => e.Age)
                    .HasColumnType("int")
                    .HasColumnName("Age");

                entity.Property(e => e.Town)
                        .HasMaxLength(255)
                        .HasColumnName("Town");


            });

            modelBuilder.Entity<Battle>(entity =>
            {
                entity.ToTable("Battle", "SamuraiBattle");

                entity.HasComment("Battle information.");


                entity.Property(x => x.BattleID)
                        .HasColumnName("BattleID")
                        .HasComment("Primary key for Customer records.");

                entity.Property(e => e.FightDate)
                       .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())")
                        .HasComment("Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasComment("Name");

          

                entity.Property(e => e.Location)
                       .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnName("Town");


            });

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// connects SQL server database provider to find the database 
        /// </summary>
        /// <param name="optionsBuilder"></param>
      
    }
}
