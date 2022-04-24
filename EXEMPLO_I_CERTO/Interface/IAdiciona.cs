using EXEMPLO_I_CERTO.Classes;

namespace EXEMPLO_I_CERTO.Interface
{
    public interface IAdiciona<Elemento> where Elemento : EntidadeBase
    {
        public bool Adiciona(Elemento elemento);
    }
}
