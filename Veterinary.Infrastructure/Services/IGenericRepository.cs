

namespace Veterinary.Infrastructure.Services
{
    public interface IGenericRepository<T>//la T indica que recibe un parametro de tipo generico
    {
        //clientes
        //Ver muchos clientes:
        public Task<IEnumerable<T>> GetAll();
       
        //Para guardar un cliente o actualizarlo:
        public Task Insert(T entity);
        public Task Update(T entity);

        //Para dar de baja a un cliente:
        public Task Delete(int id);
        //esta clase recibira un paciente, una provincia, obtener 1 por id o borrarlo
        
    }
}
