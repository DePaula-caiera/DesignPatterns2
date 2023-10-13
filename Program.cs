using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);


        }
    }
}
