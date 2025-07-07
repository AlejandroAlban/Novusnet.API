using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novusnet.Dominio.Modelo.Abstracciones
{
    public interface IRepositorio<T> where T : class
    {
        Task AddAsync(T entidad); //insertar
        Task UpdateAsync(T entidad); //actualizar
        Task DeleteAsync(int id ); //eliminar 
        Task<IEnumerable<T>> GetAllAsync(); //listar todos SELECT * FROM tabla
        Task<T> GetByIdAsync(int id); //buscar por id   SELECT * FROM tabla WHERE id = @id
    }
    {
    }
}
