namespace OOP
{
    public interface IRepositorio
    {
        // a interface é uma espécie de contrato

        // toda classe que implementa uma interface é obrigada
        // a implementar os métodos que são especificados aqui 
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        // aqui temos a necessidade de implementar o método adicionar
        // devido ao contrato
        public void Adicionar()
        {
            // Adiciona Item
        }
    }

    public class RepositorioFake : IRepositorio
    {
        // usado para testes, simulação, não é persisitido
        public void Adicionar()
        {
            // Adiciona Item
        }
    }

    public class UsoImplementacao
    {
        // aqui temos um processo que cria uma instância do repositorio
        // e chama o método adicionar

        // implementado uma classe concreta
        // esse é o principio do acoplamento (diretamente ligado) ->
        // a classe que está implementando sofre quando a classe que está sendo implementada é alterada
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        // usando contrato 
        // abstração do uso da classe
        private readonly IRepositorio _repositorio;

        //injeção da dependência no construtor da classe
        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
