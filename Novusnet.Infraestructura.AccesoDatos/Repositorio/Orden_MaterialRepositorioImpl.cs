using Novusnet.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novusnet.Infraestructura.AccesoDatos.Repositorio
{
    internal class Orden_MaterialRepositorioImpl : RepositorioImpl<Orden_Material>, IOrden_MaterialRepositorio
    {
        public Orden_MaterialRepositorioImpl(NovusnetPRODBContext dBContext) : base(dBContext)
        {
        }
    }
}
