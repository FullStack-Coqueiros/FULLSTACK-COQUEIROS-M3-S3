using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class PersistenciaEmArquivo : IPersistenciaFatura
    {
        public void salvar(Fatura fatura)
        {
            Console.WriteLine("Salvando em Arquivo, fatura de " + fatura.quantidade + " livros.");
        }
    }
}
