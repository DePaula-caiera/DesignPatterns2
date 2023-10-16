using DesignPatterns2.Cap3;
using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap9
{
    class EmpresaFacade
    {
        //APENAS EXEMPLO DE FAÇADE

        //public Cliente BuscaCliente(string cpf)
        //{
        //    return new ClienteDAO().BuscaPorCpf(cpf);
        //}

        //public Fatura criaFatura(Cliente cliente, double valorFatura)
        //{
        //    return new Fatura(cliente, valorFatura);
        //}

        //public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        //{
        //    Cobranca cobranca = new GeraCobranca(tipo, fatura);
        //    cobranca.Emite();
        //    return cobranca;
        //}

        //public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        //{
        //    ContatoCliente contato = new ContatoCliente(cliente, cobranca);
        //    contato.Dispara();
        //    return contato;
        //}
    }
}
