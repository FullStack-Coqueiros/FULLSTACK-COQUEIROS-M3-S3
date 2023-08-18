using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class PersistenciaEmBD : IPersistenciaFatura, IPersistenciaLivro
    {
        public void salvar(Fatura fatura)
        {
            Console.WriteLine("Salvando em BD, fatura de " + fatura.quantidade + " livros.");
        }

        public void salvar(Livro pLivro)
        {
            Console.WriteLine("Salvando em BD, o livro " + pLivro.nome + ".");
        }
    }
}
