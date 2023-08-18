using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Geometrico
{
    public class Quadrado : Retangulo
    {
        public Quadrado() { }

        public Quadrado(int tamanho)
        {
            largura = altura = tamanho;
        }

        public void setLargura(int largura)
        {
            this.largura = largura;
            this.altura = largura;
        }

        public void setAltura(int altura)
        {
            this.altura = altura;
            this.largura = altura;
        }


    }
}
