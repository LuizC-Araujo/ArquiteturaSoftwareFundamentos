namespace Solid.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debito Conta Investimento
            // Isentar Taxas
            return FormatarTransacao();
        }
    }
}
