using Microsoft.EntityFrameworkCore;
using Novusnet.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Novusnet.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly NovusnetPRODBContext _dBContext;
        private readonly DbSet<T> _dbSet;
        public RepositorioImpl(NovusnetPRODBContext dBContext) {  
        
        _dBContext = dBContext ;
        _dbSet = _dBContext.Set<T>();
        
        }
        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad); // insert todas las tablas que heredan de la clase T
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception("Error al insertar la entidad en la base de datos.");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entidad = await GetByIdAsync(id);
                _dbSet.Remove(entidad); // eliminar todas las tablas que heredan de la clase T
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception("Error al eliminar la entidad en la base de datos.");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                
              return await _dbSet.ToListAsync(); // listar todas las tablas que heredan de la clase T
               
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar la entidad en la base de datos, " + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
          try
          {
           return await  _dbSet.FindAsync(id); // buscar por id todas las tablas que heredan de la clase T siempre y cuando sean numeros
          }
          catch (Exception ex)
         {
            throw new Exception("Error al recuperar la entidad por ID, " + ex.Message);
         }
}

       public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad); // actualizar todas las tablas que heredan de la clase T
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar datos." + ex.Message);
            }
        }
    }
}








