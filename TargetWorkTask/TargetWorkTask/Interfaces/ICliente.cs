using TargetWorkTask.Models;

namespace TargetWorkTask.Interfaces
{
    public interface ICliente : IGeneric<Cliente>
    {
        Task AdicionarClinete(Cliente objeto);
        Task<Cliente> BuscarClinete(int Id);
        Task<List<Cliente>> ListarClientes();
    }
}
