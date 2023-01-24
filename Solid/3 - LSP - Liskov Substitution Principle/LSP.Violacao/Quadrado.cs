﻿namespace Solid.LSP.Violacao
{
    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Largura = base.Altura = value; }
        }
    }
}
