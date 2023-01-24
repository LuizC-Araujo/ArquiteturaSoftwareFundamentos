namespace Solid.OCP.Violacao
{
    public class DebitoConta
    {

        // Não está fechada para modicação
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta != TipoConta.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
