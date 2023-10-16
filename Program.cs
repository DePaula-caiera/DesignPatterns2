using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            // AULA 1 
            //IDbConnection conexao = new ConnectionFactory().GetConnection();

            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela";
            // FIM AULA 1

            // AULA 2
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //};
            //Piano piano = new Piano();
            //piano.Toca(musica);
            //FIM AULA 2

            // AULA 3
            // Historico historico = new Historico();

            // Contrato c = new Contrato(DateTime.Now,"Joaquim Piquerez", TipoContrato.Novo);
            // historico.Adiciona(c.SalvaEstado());            

            // c.Avanca();
            // historico.Adiciona(c.SalvaEstado());

            // c.Avanca();
            // historico.Adiciona(c.SalvaEstado());

            //// Console.WriteLine(c.Tipo);
            // Console.WriteLine(historico.Captura(2).Contrato.Tipo);
            // FIM AULA 3

            // AULA 4
            // SOMA: ((1 + 100) + 10) + (20 - 10)
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //Expression            
            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());

            // DIVISÃO: (10 / 5)
            //IExpressao esquerda = new Numero(10);
            //IExpressao direita = new Numero(5);
            //IExpressao divisao = new Divisao(esquerda, direita);

            //Console.WriteLine(divisao.Avalia());

            // MULTIPLICACAO: (10 * 60)
            //IExpressao esquerda = new Numero(10);
            //IExpressao direita = new Numero(60);
            //IExpressao multiplicacao = new Multiplicacao(esquerda, direita);

            //Console.WriteLine(multiplicacao.Avalia());

            // CAP 5
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());
            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);

            // CAP 6
            //IMensagem mensagem = new MensagemCliente("Rony");
            //IEnviador enviador = new EnviaPorSMS();
            //mensagem.Enviador = enviador;
            //mensagem.Envia();

            // CAP 7
            //FilaDeTrabalho fila = new FilaDeTrabalho();
            //Pedido pedido1 = new Pedido("Carlos", 150.0);
            //Pedido pedido2 = new Pedido("Rafaela", 50.0);

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));

            //fila.Adiciona(new FinalizaPedido(pedido1));
            //fila.Adiciona(new FinalizaPedido(pedido2));

            //fila.Processa();

            // CAP 8
            //Cliente cliente = new Cliente();

            //cliente.Nome = "Rafael Marques";
            //cliente.Endereco = "Rua Rei dos Clássicos";
            //cliente.DataNascimento = DateTime.Now;

            //String xml = new GeradorXml().GeraXml(cliente);

            //Console.WriteLine(xml);

            // CAP 9
            //APENAS EXEMPLO
            //String cpf = "0122334455";
            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura =  facade.criaFatura(cliente, 5000);
            //facade.GeraCobranca(tipo.Boleto, fatura);
        }
    }
}
