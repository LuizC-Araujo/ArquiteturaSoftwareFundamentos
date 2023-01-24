namespace Solid.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Valida aniversário da conta
            // Debita Conta Poupança
            return FormatarTransacao();
        }
    }
}
