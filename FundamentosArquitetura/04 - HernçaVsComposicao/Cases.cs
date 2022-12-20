namespace OOP
{
    public class Cases
    {
        #region Caso 1

        // herança
        public class PessoaFisica : Pessoa
        {
            public string Cpf { get; set; }
        }

        // composição
        public class PessoaFisica2
        {
            public Pessoa Pessoa { get; set; }
            public string Cpf { get; set; }
        }

        public class TestesHerancaComposicao
        {
            public TestesHerancaComposicao()
            {
                var pessoaHeranca = new PessoaFisica
                {
                    Name = "João",
                    DataNascimento = DateTime.Now,
                    Cpf = "12345678911"
                };

                var pessoaComposicao = new PessoaFisica2
                {
                    Pessoa = new Pessoa
                    {
                        Name = "João",
                        DataNascimento = DateTime.Now
                    },
                    Cpf = "12345678911"
                };

                var nomeHeranca = pessoaHeranca.Name;
                var nomeComposicao = pessoaComposicao.Pessoa.Name;
            }
        }

        #endregion

        #region Caso 2

        // repositório genérico
        public interface IRepositorio<T>
        {
            void Adicionar(T obj);
            void Excluir(T obj);
        }

        // repositório especializado
        public interface IRepositorioPessoa
        {
            void Adicionar(Pessoa obj);
        }

        public class Repositorio<T> : IRepositorio<T>
        {
            public void Adicionar(T obj)
            {
                
            }

            public void Excluir(T obj)
            {
                
            }
        }

        // herança
        public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
        {

        }


        // composição
        public class RepositorioComposicaoPessoa : IRepositorioPessoa
        {
            private readonly IRepositorio<Pessoa> _repositorioPessoa;

            public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
            {
                _repositorioPessoa = repositorioPessoa;
            }

            public void Adicionar(Pessoa obj)
            {
                _repositorioPessoa.Adicionar(obj);
            }           
        }

        public class TestesHerancaComposicao2
        {
            public TestesHerancaComposicao2()
            {
                var repoH = new RepositorioHerancaPessoa();
                repoH.Adicionar(new Pessoa());
                repoH.Excluir(new Pessoa());

                var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
                repoC.Adicionar(new Pessoa());
            }
        }

        #endregion
    }
}
