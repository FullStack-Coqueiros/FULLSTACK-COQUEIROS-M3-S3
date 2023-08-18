using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Estacionamento
{
    public class EstacionamentoRotativo : IEstacionamento, IEstacionamentoPago
    {
        public double calcularTaxa(Carro carro)
        {
            throw new NotImplementedException();
        }

        public void estacionarCarro()
        {
            throw new NotImplementedException();
        }

        public void getCapacidade()
        {
            throw new NotImplementedException();
        }

        public void pagar(Carro carro)
        {
            throw new NotImplementedException();
        }

        public void sairDaVagaComCarro()
        {
            throw new NotImplementedException();
        }
    }
}
