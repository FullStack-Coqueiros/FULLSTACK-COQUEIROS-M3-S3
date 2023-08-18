using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Livraria
{
    public class ImpressaoFatura
    {
        Fatura fatura;

        public ImpressaoFatura(Fatura fatura)
        {
            this.fatura = fatura;
        }

        public void imprimirFatura()
        {
            Console.WriteLine(fatura.quantidade + "x " + fatura.livro.nome + " " + fatura.livro.preco + "$");
            Console.WriteLine("Porcentagem de desconto: " + fatura.porcDesconto);
            Console.WriteLine("Procentagem de imposto: " + fatura.porcImposto);
            Console.WriteLine("Total: " + fatura.total);
        }

    }
}
