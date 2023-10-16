using DesignPatterns2.Cap5;
using System;

namespace DesignPatterns2.Cap4
{
    class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;
        }        

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeDivisao(this);
        }
    }
}
