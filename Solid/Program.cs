using Solid.LSP.Solucao;
using Solid.OCP.Solucao.Extension.Methods;

Console.WriteLine("Escolha uma operação");
Console.WriteLine("1 - OCP");
Console.WriteLine("2 - LSP");

var op = Console.ReadKey();

switch (op.KeyChar)
{
    case '1':
        CaixaEletronico.Operacoes();
        break;
    case '2':
        CalculaArea.Calcular();
        break;
}
