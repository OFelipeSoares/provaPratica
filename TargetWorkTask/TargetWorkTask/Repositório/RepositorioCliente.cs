using Microsoft.AspNetCore.Identity;
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

        

        public async Task AdicionarCliente(Cliente Objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                await data.Set<Cliente>().AddAsync(Objeto);
                await data.SaveChangesAsync();
                /*
                if(Objeto.Produtos.Any())
                {
                    Objeto.Produtos.ForEach(a => a.IdCliente = Objeto.Id);
                }*/
            }
        }

        public async Task<Cliente> BuscarCliente(int Id)
        {
            using (var data = new ContextBase(_optionsBuilder)) 
            {
                
                var cliente = await data.Cliente.FindAsync(Id);
                if (cliente != null)
                {

                    var produtos = await data.produtos.FindAsync(a => a.IdCliente.Equals(Id).ToListAsync());

                    if (produtos.Any())
                        cliente.produtos = produtos;

                    return cliente;

                } else return null; 

            }
            
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            var ClientesLista = new List<Cliente>();

            using (var data = new ContextBase(_optionsBuilder))
            {
                var ListarClientesCadastrados = await (from TA in data.Cliente join ITA in data.produtos on TA.Id equals
                                                       ITA.IdCliente select new
                                                       {
                                                           Id = TA.Id,
                                                           Nome = TA.Nome,
                                                           IdProduto = TA.IdProduto,
                                                       }).ToListAsync();
            }
        }
    }
}
