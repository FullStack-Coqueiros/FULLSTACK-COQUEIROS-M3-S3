using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class Livro
    {
       public string nome;
       public string nomeAutor;
       public int ano;
       public int preco;
       public string isbn;

        //public Livro()
        //{
            
        //}

        public Livro(string nome, string nomeAutor, int ano, int preco, string isbn)
        {
            this.nome = nome;
            this.nomeAutor = nomeAutor;
            this.ano = ano;
            this.preco = preco;
            this.isbn = isbn;
        }
    }
}
