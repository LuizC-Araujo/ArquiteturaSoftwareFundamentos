using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada(); // não posso pq é privada / com a linha no projetoA eu consigo
            //var interna = new Interna(); // não posso pq não faz parte do mesmo assembly / com a linha no projetoA eu consigo
            //var abstrata = new Abstrata(); não posso pq é abstrata
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            //aqui também só consigo acessar o método público
            var publica = new Publica();
            
            publica.TestePublico();

            // pelo interno tenho acessos a dois métodos a mais

            //publica.TesteInternal();
            //publica.TesteProtegidoInterno();

            // esses não consigo acessar 

            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            // herdando do outro assembly eu consigo os três métodos:

            TestePublico();
            TesteProtegido();
            TesteProtegidoInterno();

            // esses não consigo acessar 

            //TesteInternal();
            //TestePrivadoProtegido(); / para esse nível deve ser uma herança e estar no mesmo assembly
            //TestePrivado();
        }
    }
}
