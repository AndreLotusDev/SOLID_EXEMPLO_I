using EXEMPLO_I_CERTO.Classes;
using LiteDB;
using System.Collections.Generic;

namespace EXEMPLO_I_CERTO.Interface
{
    public interface IVisualiza<Elemento> where Elemento : EntidadeBase
    {
        public IEnumerable<Elemento> PegaTodosElementos();
        public Elemento PegaSomenteUmElemento(ObjectId id);
    }
}
