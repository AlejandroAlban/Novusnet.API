using Novusnet.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novusnet.Infraestructura.AccesoDatos.Repositorio
{
    public class Orden_TrabajoRepositorioImpl : RepositorioImpl<Orden_Trabajo>, IOrden_TrabajoRepositorio
    {
        public Orden_TrabajoRepositorioImpl(NovusnetPRODBContext dBContext) : base(dBContext)
        {
        }
    }
}
