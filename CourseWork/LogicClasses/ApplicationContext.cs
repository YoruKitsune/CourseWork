using CourseWork.DocumentsClasses;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<PersonClass> Persons => Set<PersonClass>();
    public DbSet<CertificateOfBirth> CertificatesOfBirth => Set<CertificateOfBirth>();
    public DbSet<CertificateOfDeath> CertificateOfDeath => Set<CertificateOfDeath>();
    public DbSet<CertificateOfAdoption> CertificateOfAdoption => Set<CertificateOfAdoption>();
    public DbSet<CertificateOfChangeName> CertificateOfChangeName => Set<CertificateOfChangeName>();
    public DbSet<CertificateOfDivorce> CertificateOfDivorce => Set<CertificateOfDivorce>();
    public DbSet<CertificateOfEstablishingPaternity> CertificateOfEstablishingPaternity => Set<CertificateOfEstablishingPaternity>();
    public DbSet<CertificateOfMarriage> CertificateOfMarriage => Set<CertificateOfMarriage>();
    public DbSet<CertificateClass> CertificateClass => Set<CertificateClass>();

   
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      
        optionsBuilder.UseSqlite("Data Source=helloapp.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CertificateClass>().HasKey(u => new { u.Series, u.Number });
        modelBuilder.Entity<CertificateClass>().UseTpcMappingStrategy();
        
      
    }
}