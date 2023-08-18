using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public interface IPersistenciaFatura
    {
        public void salvar(Fatura fatura);
    }
}
