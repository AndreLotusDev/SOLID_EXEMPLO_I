using EXEMPLO_I_ERRADO.Banco;
using EXEMPLO_I_ERRADO.Classes;
using EXEMPLO_I_ERRADO.Interface;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace EXEMPLO_I_ERRADO.Servicos
{
    public class FuncionarioServico : ICrud<Funcionario>
    {
        private GerenciadorBanco<Funcionario> banco;
        public FuncionarioServico()
        {
            banco = new GerenciadorBanco<Funcionario>();
        }
        public void Adiciona(Funcionario funcionario)
        {
            banco.Adiciona(funcionario);
        }

        public void Atualiza(Funcionario funcionario)
        {
            banco.Atualiza(funcionario);
        }

        public void Deleta(ObjectId id)
        {
            banco.Remove(id);
        }

        public List<Funcionario> TrazElementos()
        {
            return banco.PegaElementos().ToList();
        }

        public void Dispose()
        {
            banco.Dispose();
        }
    }
}
