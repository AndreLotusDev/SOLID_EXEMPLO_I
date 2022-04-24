using EXEMPLO_I_CERTO.Banco;
using EXEMPLO_I_CERTO.Classes;
using EXEMPLO_I_CERTO.Interface;
using LiteDB;
using System.Collections.Generic;

namespace EXEMPLO_I_CERTO.Servicos.DocumentoServicos
{
    public class DocumentoVisualizaService : IVisualiza<Documento>
    {
        public GerenciadorBanco<Documento> banco = new GerenciadorBanco<Documento>();
        public Documento PegaSomenteUmElemento(ObjectId id)
        {
            return banco.PegaUm(id);
        }

        public IEnumerable<Documento> PegaTodosElementos()
        {
            return banco.PegaElementos();
        }
    }
}
