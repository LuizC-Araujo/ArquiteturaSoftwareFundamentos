namespace OOP;

// Definição de Classe
public class Casa
{
    // Representa os dados de qualquer coisa do mundo real
    public int TamanhoM2 { get; set; }
    public int Andares { get; set; }
    public decimal Valor { get; set; }
    public int NumeroVagas { get; set; }
}

public class Objeto
{
    // Definição de Objeto
    public Objeto()
    {
        // Uma instância da classe
        var casa = new Casa
        {
            TamanhoM2 = 100,
            Andares = 3,
            Valor = 100000,
            NumeroVagas = 2
        };
    }
}
