using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemAdmnistrativa : IMensagem
    {
        public string Nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdmnistrativa(string nome)
        {
            this.Nome = nome;            
        }
        
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}.", Nome);
        }
    }
}
