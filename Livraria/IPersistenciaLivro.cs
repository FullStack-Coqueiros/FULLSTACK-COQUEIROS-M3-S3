using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public interface IPersistenciaLivro
    {
        public void salvar(Livro pLivro);
    }
}
