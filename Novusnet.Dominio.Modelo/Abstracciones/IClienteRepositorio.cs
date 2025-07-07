using Novusnet.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novusnet.Dominio.Modelo.Abstracciones
{
    public interface IClienteRepositorio :IRepositorio<Cliente>
    {
        /// Métodos específicos para el repositorio de Cliente, si es necesario
    }
}
