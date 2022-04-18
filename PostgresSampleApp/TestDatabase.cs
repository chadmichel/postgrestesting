using Microsoft.EntityFrameworkCore;

namespace PostgresSampleApp
{
    public class TestDatabase : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)   {             
            modelBuilder.HasDefaultSchema("public");                  
            base.OnModelCreating(modelBuilder);         
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=TestDatabase;Username=testuser;Password=password");
        
    }
}