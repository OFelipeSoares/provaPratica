using Microsoft.EntityFrameworkCore;
using TargetWorkTask.Config;
using TargetWorkTask.Interfaces;
using TargetWorkTask.Models;

namespace TargetWorkTask.Repositório
{
    public class RepositorioCliente : RepositorioGenerico<Cliente>, ICliente
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;
        public RepositorioCliente()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task AdicionarClinete(Cliente Objeto)
        {
            using( var data = new ContextBase(_optionsBuilder))
            {
                await data.Set<Cliente>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<Cliente> BuscarClinete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            throw new NotImplementedException();
        }
    }
}
