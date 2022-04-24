using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Interface;

namespace EXEMPLO_I_CERTO.Servicos.FuncionarioServicos
{
    public class FuncionarioAtualizaServico : IAtualiza<Funcionario>
    {
        public GerenciadorBanco<Funcionario> banco = new GerenciadorBanco<Funcionario>();
        public bool Atualiza(Funcionario funcionario)
        {
            return banco.Atualiza(funcionario);
        }
    }
}
