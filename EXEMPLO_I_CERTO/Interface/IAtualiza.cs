using EXEMPLO_I_CERTO.Classes;

namespace EXEMPLO_I_CERTO.Interface
{
    public interface IAtualiza<Elemento> where Elemento : EntidadeBase
    {
        public bool Atualiza(Elemento elemento);
    }
}
