using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Interface;
using LiteDB;

namespace EXEMPLO_I_CERTO.Servicos.FuncionarioServicos
{
    public class FuncionarioDeletaServico : IDeleta
    {
        public GerenciadorBanco<Funcionario> banco = new GerenciadorBanco<Funcionario>();
        public bool Deleta(ObjectId id)
        {
            return banco.Remove(id);
        }
    }
}
