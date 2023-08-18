using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class Fatura
    {
        public Livro livro;
        public int quantidade;
        public double porcDesconto;
        public double porcImposto;
        public double total;

        public Fatura(Livro livro, int quantidade, double porcDesconto, double porcImposto)
        {
            this.livro = livro;
            this.quantidade = quantidade;
            this.porcDesconto = porcDesconto;
            this.porcImposto = porcImposto;
            this.total = this.calcularTotal();
        }

        public double calcularTotal()
        {
            double preco = ((livro.preco - livro.preco * porcDesconto) * this.quantidade);

            double precoComImposto = preco * (1 + porcImposto);

            return precoComImposto;
        }
    }
}
