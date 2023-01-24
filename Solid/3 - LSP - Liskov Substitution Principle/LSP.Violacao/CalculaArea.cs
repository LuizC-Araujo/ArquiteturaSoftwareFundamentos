﻿namespace Solid.LSP.Violacao
{
    public class CalculaArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine();
            Console.WriteLine($"{ret.Altura} * {ret.Largura}");
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}
