using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Interface;
using LiteDB;
using System.Collections.Generic;

namespace EXEMPLO_I_CERTO.Servicos.FuncionarioServicos
{
    public class FuncionarioVisualizaServico : IVisualiza<Funcionario>
    {
        public GerenciadorBanco<Funcionario> banco = new GerenciadorBanco<Funcionario>();
        public Funcionario PegaSomenteUmElemento(ObjectId id)
        {
            return banco.PegaUm(id);
        }

        public IEnumerable<Funcionario> PegaTodosElementos()
        {
            return banco.PegaElementos();
        }
    }
}
