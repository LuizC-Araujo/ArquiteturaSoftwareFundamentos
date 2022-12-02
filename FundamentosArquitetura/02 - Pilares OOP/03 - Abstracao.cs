namespace OOP
{
    // superclasse - abestração
    // só pode ser herdada, nunca instanciada, devido ao abstract
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        // não é obrigado a implementar quando tem abstract
        public abstract void Ligar();
        public abstract int Desligar();
    }
}
