using Microsoft.EntityFrameworkCore;
using TargetWorkTask.Models;

namespace TargetWorkTask.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConect());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string GetStringConect()
        {
            return "Data Source = DESKTOP - J4MKG5R\\SQLSERVER; Initial Catalog = Crud7; Integrated Security = True";
        }


    }
}
