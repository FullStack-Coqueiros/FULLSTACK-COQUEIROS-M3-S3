using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Estacionamento
{
    public interface IEstacionamento
    {
       public void estacionarCarro(); 
       public void sairDaVagaComCarro(); 
       public void getCapacidade();   
       
    }
}
