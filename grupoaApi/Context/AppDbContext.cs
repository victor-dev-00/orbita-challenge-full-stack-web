using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace grupoaApi.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) 
    {
        public DbSet<Student> Students{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Student>().HasData(new Student() { Ra = 1, Name = "Victor", Cpf = "12345678910", Email = "qBc3w@example.com" });
        }
    }
}
