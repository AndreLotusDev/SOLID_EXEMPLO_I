using EXEMPLO_I_ERRADO.Banco;
using EXEMPLO_I_ERRADO.Classes;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace EXEMPLO_I_ERRADO.Servicos
{
    public class DocumentoServico
    {
        private GerenciadorBanco<Documento> banco;
        public DocumentoServico()
        {
            banco = new GerenciadorBanco<Documento>();
        }
        public void Adiciona(Documento documento)
        {
            banco.Adiciona(documento);
        }

        public void Atualiza(Documento documento)
        {
            banco.Atualiza(documento);
        }

        public void Deleta(ObjectId id)
        {
            banco.Remove(id);
        }

        public List<Documento> TrazElementos()
        {
            return banco.PegaElementos().ToList();
        }

        public void Dispose()
        {
            banco.Dispose();
        }
    }
}
