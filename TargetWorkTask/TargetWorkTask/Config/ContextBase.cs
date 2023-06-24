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

        public string GetStringConect()

    }
}
