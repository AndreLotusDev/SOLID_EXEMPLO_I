using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Interface;

namespace EXEMPLO_I_CERTO.Servicos.FuncionarioServicos
{
    public class FuncionarioAdicionaServico : IAdiciona<Funcionario>
    {
        public GerenciadorBanco<Funcionario> banco = new GerenciadorBanco<Funcionario>();
        public bool Adiciona(Funcionario funcionario)
        {
            return banco.Adiciona(funcionario);
        }
    }
}
