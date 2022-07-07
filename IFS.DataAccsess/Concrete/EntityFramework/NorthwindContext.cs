using IFS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IFS.DataAccsess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP - SNQMH12; Database = StajyerTakip; trusted_Connection = true");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Company> Companys { get; set; }
    }
}
