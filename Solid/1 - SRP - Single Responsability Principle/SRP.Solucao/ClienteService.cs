namespace Solid.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("email@email.com", cliente.Email.Endereco, "Bem Vindo", "Seja bem vindo ao nosso sistema");

            return "Cliente cadastrado com sucesso";
        }
    }
}
