using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ProjetoB")] //Dessa forma internal funciona no outro projeto
namespace ProjetoA
{
    #region Classes
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { } // classes seladas não podem ser herdadas

    class Privada { } // sem modificador de acesso é privada

    internal class Interna { }

    abstract class Abstrata { }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata(); não pode ser instanciada
        }
    }
    //class TesteSelada : Selada { } não pode ser instanciada

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal(); // dentro do mesmo assembly
            publica.TesteProtegidoInterno(); // está internos dentro do mesmo assembly
            //publica.TesteProtegido(); não consigo chamar pq não estou herdando da classe
            //publica.TestePrivadoProtegido(); deve estar herdando
            //publica.TestePrivado(); método privado não pode ser chamado
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado(); não conseguimos chamar, nem herdando
        }
    }

    #endregion
}

/**********************************************************/
// public:
// Acesso não é restrito
/**********************************************************/

// protected
// Acesso é limitado a classe que contém o tipo derivado da classe
/**********************************************************/

// internal
// Acesso é limitado apenas ao assembly - dll
/**********************************************************/

// protected internal - para métodos
// Limitadas ao assmbly ou derivadas dessas classes
/**********************************************************/

// private
// Acesso limitado apenas para a classe
/**********************************************************/

// private protected - para métodos
// acesso é limitado apenas paras as classes que derivam ou
// se estão no mesmo assembly - dispon[ivel desde o C# 7.2
/**********************************************************/

