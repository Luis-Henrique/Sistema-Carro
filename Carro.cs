
public class Carro 
{
    public int Portas { get; }
    public string Modelo {get; }
    public Cor Cor {get; set; }

    private bool ligado = false;

    public bool Ligado 
    {
        get
        {
        return ligado;
        }
    }

    public Carro(Cor cor, int portas, string modelo)
    {
        Cor = cor;
        Portas = portas;
        Modelo - modelo;
    }

    public string Ligar()
    {
        ligado = true;
        return "O Carro foi ligado";
    }

    public string Desligar()
    {
        ligado = false;
        return "O Carro foi desligado";
    }  

    public string Andar()
    {
        return "O Carro está andando";
    }  
}