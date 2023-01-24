namespace Solid.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Lógica de negócio para débito em conta investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
