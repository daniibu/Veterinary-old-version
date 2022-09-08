

namespace Veterinary.Infrastructure.Services
{
    public interface IRepositoryGeneric<T>//la t indica que recibe un parametro de tipo generico
    {
        //clientes
        //Ver muchos clientes:
        public Task<IEnumerable<T>> GetClientId();
       
        //Para guardar un cliente o actualizarlo:
        public Task InsertClientById(T entity);
        public Task UpdateClientById(T entity);

        //Para dar de baja a un cliente:
        public Task DeleteClientById(int id);
        //esta clase recibira un paciente, una provincia, obtener 1 por id o borrarlo
        
    }
}
