using EXEMPLO_I_ERRADO.Classes;
using LiteDB;
using System.Collections.Generic;

namespace EXEMPLO_I_ERRADO.Interface
{
    public interface ICrud<Elemento> where Elemento : EntidadeBase
    {
        public void Adiciona(Elemento elemento);
        public void Deleta(ObjectId id);
        public void Atualiza(Elemento elemento);
        public List<Elemento> TrazElementos();
    }
}
