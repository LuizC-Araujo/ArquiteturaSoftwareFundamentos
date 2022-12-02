namespace OOP
{
    // formas diferentes
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) 
            : base(nome, voltagem)
        {
        }

        public CafeteiraExpressa()
            : base("Padrão", 220)
        {
        }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar(); // Não posso modificar o comportamento de testar() sem virtual
            AquecerAgua();
            MoerGraos();
        }

        // agora posso utilizar o testar com o virtual
        public override void Testar()
        {
            // teste de cafeteira
        }

        public override void Desligar()
        {
            // Verificar recipiente de água
        }

        public override void Ligar()
        {
            // Resfriar aquecedor
        }
    }
}
