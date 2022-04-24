using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Servicos.DocumentoServicos;
using EXEMPLO_I_CERTO.Servicos.FuncionarioServicos;
using LiteDB;
using System;
using System.Collections.Generic;

namespace EXEMPLO_I_CERTO
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------LIMPEZA DE BANCO (FUNCIONARIOS)

            GerenciadorBanco<Funcionario> gerenciadorBanco = new();
            gerenciadorBanco.LimpaColecao();
            gerenciadorBanco.Dispose();

            //---------------------------------------FUNCIONARIO AREA

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            var funcionarioUm = new Funcionario("Andre Soares Gomes", 1_500);
            var funcioarioDois = new Funcionario("Barbara Silveira Souza", 2_700);

            FuncionarioAdicionaServico funcionarioServico = new();
            funcionarioServico.Adiciona(funcionarioUm);
            funcionarioServico.Adiciona(funcioarioDois);

            funcionarioServico.banco.Dispose();

            FuncionarioVisualizaServico funcionarioVisualizaServico = new();

            foreach (var funcionario in funcionarioVisualizaServico.PegaTodosElementos())
            {
                Console.WriteLine(funcionario.ToString());
            }
            
            funcionarioVisualizaServico.banco.Dispose();

            Console.WriteLine("-------------------------------------------------------");

            //-------------------------------------DOCUMENTO AREA

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            DocumentoVisualizaService documentoVisualizaServico = new();

            var idList = new List<ObjectId>();
            foreach (var documento in documentoVisualizaServico.PegaTodosElementos())
            {
                Console.WriteLine(documento.ToString());

                idList.Add(documento.Id);
            }

            Console.WriteLine("-------------------------------------------------------");

            foreach (var idPesquisar in idList)
            {
                var documentoEncontrado = documentoVisualizaServico.PegaSomenteUmElemento(idPesquisar);
                Console.WriteLine(documentoEncontrado.ToString());
            }

            documentoVisualizaServico.banco.Dispose();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
