using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using TargetWorkTask.Config;
using TargetWorkTask.Interfaces;

namespace TargetWorkTask.Repositório
{
    public class RepositorioGenerico<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _opstionsbulder;
        public RepositorioGenerico() 
        {
            _opstionsbulder = new DbContextOptions<ContextBase>();
        }
        public async Task Adiconar(T Objeto)
        {
            using(var data = new ContextBase(_opstionsbulder)) 
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Atualizar(T Objeto)
        {
            using (var data = new ContextBase(_opstionsbulder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> BuscarPorCodigo(int Id)
        {
            using (var data = new ContextBase(_opstionsbulder))
            {
                return await data.Set<T>().FindAsync(Id);
               
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(T Objeto)
        {
            using (var data = new ContextBase(_opstionsbulder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<List<T>> ListarTudo()
        {
            using (var data = new ContextBase(_opstionsbulder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }
    }
    #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    // Flag: Has Dispose already been called?
    bool disposed = false;
    // Instantiate a SafeHandle instance.
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            handle.Dispose();
            // Free any other managed objects here.
            //
        }

        disposed = true;
    }
    #endregion
}

