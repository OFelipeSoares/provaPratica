using Microsoft.EntityFrameworkCore;
using TargetWorkTask.Models;

namespace TargetWorkTask.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<BaseId> BaseId { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb; database=Crud7; Integrated Security = True");
        }
    }
}
