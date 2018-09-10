using Microsoft.EntityFrameworkCore;

namespace EFNew
{
    public class FruitsContext:DbContext
    {
        public DbSet <Fruit> Fruits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EfNew;");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
