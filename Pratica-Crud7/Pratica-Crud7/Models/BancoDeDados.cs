using Microsoft.EntityFrameworkCore;

namespace Pratica_Crud7.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;database=Crud7; Integrated Security = True");
        }
    }
}
