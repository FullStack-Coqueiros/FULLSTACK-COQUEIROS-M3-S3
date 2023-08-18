using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Geometrico
{
    public class Retangulo
    {
        protected int largura, altura;

        public Retangulo()
        {
        }

        public Retangulo(int largura, int altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public int getLargura()
        {
            return largura;
        }

        public void setLargura(int largura)
        {
            this.largura = largura;
        }

        public int getAltura()
        {
            return altura;
        }

        public void setAltura(int altura)
        {
            this.altura = altura;
        }

        public int getArea()
        {
            return largura * altura;
        }
    }
}
