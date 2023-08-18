using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class GerentePersistencia
    {
        public IPersistenciaFatura persistenciaFatura;
        public IPersistenciaLivro persistenciaLivro;

        public GerentePersistencia(IPersistenciaFatura pPersistenciaFatura, IPersistenciaLivro pPersistenciaLivro)
        {
            this.persistenciaFatura = pPersistenciaFatura;
            this.persistenciaLivro = pPersistenciaLivro;
        }
    }
}
