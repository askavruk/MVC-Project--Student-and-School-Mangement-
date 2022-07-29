using _7_MVC_GenericRepository.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _7_MVC_GenericRepository.AppDbContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<School>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<School>().ToTable("Okullar");
            modelBuilder.Entity<Lesson>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<User>().Property(a => a.Name).HasMaxLength(50).IsRequired();

            //YAzmak zorunda değiliz. EF Core Navigational propertyler üzerinden görüyor.
            modelBuilder.Entity<School>()
                .HasMany(a => a.Students)
                .WithOne(b => b.School)
                .HasForeignKey(c => c.SchoolID);

            modelBuilder.Entity<Student>()
                .HasMany<Lesson>(a => a.Lessons)
                .WithMany(b => b.Students);

        }
    }
}
