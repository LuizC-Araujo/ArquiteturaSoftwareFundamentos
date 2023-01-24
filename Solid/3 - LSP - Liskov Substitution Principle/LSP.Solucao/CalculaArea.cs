namespace Solid.LSP.Solucao
{
    public class CalculaArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo par)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine();
            Console.WriteLine($"{par.Altura} * {par.Largura}");
            Console.WriteLine();
            Console.WriteLine(par.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);
            var ret = new Retangulo(10, 4);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
