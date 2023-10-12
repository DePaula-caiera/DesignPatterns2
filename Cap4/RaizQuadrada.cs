using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        RaizQuadrada(IExpressao e)
        {
            this.expressao = e;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }
    }
}
