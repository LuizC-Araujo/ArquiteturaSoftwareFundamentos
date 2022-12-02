namespace OOP
{
    // Estado é representado pelas propriedades
    public class Pessoa
    {
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }

        // Comportamento é representado pelo método gerando ou
        // processando uma informação através da própria classe
        // altera o estado da entidade
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual.Year < DataNascimento.Year)
                idade--;

            return idade;
        }
    }
}
