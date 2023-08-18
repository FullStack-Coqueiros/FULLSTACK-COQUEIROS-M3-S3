using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Estacionamento
{
    public interface IEstacionamentoPago
    {
        public double calcularTaxa(Carro carro);
        public void pagar(Carro carro);
    }
}
