namespace OOP;

public class AutomacaoCafe
{
    // esconder comportamentos privados e expor outros que faça uso desses comportamentos
    // fazer uso de um método sem saber de fato como ele funciona
    public void ServirCafe()
    {
        var expresso = new CafeteiraExpressa();
        expresso.Ligar();
        expresso.PrepararCafe();
        expresso.Desligar();
    }
}