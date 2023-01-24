namespace Solid.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaCorrente
    {
        // Extension Methods
        // quando cria um método, mas ele se comporta como se fosse um método de outra classe
        // a classe e o método precisam ser estáticos

        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negócio para débito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
