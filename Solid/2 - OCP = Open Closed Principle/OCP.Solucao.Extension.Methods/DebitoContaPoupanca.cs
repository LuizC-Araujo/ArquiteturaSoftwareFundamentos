namespace Solid.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Lógiva de negócio para débito em conta poupança
            return debitoConta.FormatarTransacao();
        }
    }
}
