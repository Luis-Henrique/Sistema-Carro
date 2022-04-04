using System;

class Program
{   
    static void Main(string[] args)
    {
        Carro carro = new Carro(cor.branco, 4, "Gol G6");

        Console.WriteLine("O carro é um {0} de cor {1} e tem {2} portas.", carro.Modelo, carro.Cor, carro.Portas);

        Console.WriteLine(carro.Ligar());
        Console.WriteLine("Ligado?" + carro.Ligado);
        Console.WriteLine(carro.Andar());
        Console.WriteLine(carro.Desligar());
        Console.WriteLine("Desligado?" + carro.Desligado);
    }
}