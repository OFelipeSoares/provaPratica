using TargetWorkTask.Models;

namespace TargetWorkTask.Interfaces
{
    public interface ICliente : IGeneric<Cliente>
    {
        Task AdicionarCliente(Cliente objeto);
        Task<Cliente> BuscarCliente(int Id);
        Task<List<Cliente>> ListarClientes();
    }
}
