using Microsoft.EntityFrameworkCore;

using CourseHub.Domain.Model;

namespace CourseHub.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Company>().HasKey(c => c.Id);
            builder.Entity<Company>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(c => c.FantasyName).IsRequired().HasMaxLength(40);
            builder.Entity<Company>().Property(c => c.SocialReason).IsRequired().HasMaxLength(50);
            builder.Entity<Company>().Property(c => c.Cnpj).IsRequired().HasMaxLength(11);
            builder.Entity<Company>().HasMany(c => c.Courses).WithOne(c => c.Company).HasForeignKey(c => c.CompanyId);
            builder.Entity<Company>().HasIndex(c => c.Cnpj).IsUnique();

            builder.Entity<Company>().HasData
            (
                new Company 
                {
                    Id = 100,
                    FantasyName = "UFC",
                    SocialReason = "Universidade Federal do Ceará",
                    Cnpj = "00935629734"
                },
                
                new Company 
                {
                    Id = 101,
                    FantasyName = "Berkeley",
                    SocialReason = "Univerity of California",
                    Cnpj = "11324522090"
                }
            );

            builder.Entity<Course>().ToTable("Courses");
            builder.Entity<Course>().HasKey(c => c.Id);
            builder.Entity<Course>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Course>().Property(c => c.Name).IsRequired();
            builder.Entity<Course>().Property(c => c.Description);
            builder.Entity<Course>().Property(c => c.Value).IsRequired().HasPrecision(6,2);
            builder.Entity<Course>().Property(c => c.Observation);

            builder.Entity<Course>().HasData
            (
                new Course 
                {
                    Id = 100,
                    Name = "Machine Learning and Deep Learning",
                    Description = "An Introduction of Machine Learning and Deep Leaning",
                    Value = 59.90,
                    Observation = "Hours: 32h",
                    CompanyId = 100
                },
                
                new Course 
                {
                    Id = 101,
                    Name = "Computer Science Specialization",
                    Description = "Specialization with Advanced Concepts Computer Science",
                    Value = 1200.90,
                    Observation = "Hours: 200h",
                    CompanyId = 101
                }
            );
        }
    }
}