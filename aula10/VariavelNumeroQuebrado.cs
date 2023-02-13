using System;

public class VariavelNumeroQuebrado
{
    public static void Main(string[] args)
    {
        double velocidadeDoCarro = 33.3;     // até 15 números decimais
        float velocidadeDeCaminhada = 2.5f;  // até 7 números decimais
        decimal dinheiroNaConta = 245.17m;  // até 29 números decimais
        
        Console.WriteLine(velocidadeDoCarro);
        velocidadeDoCarro += 7;
        Console.WriteLine(velocidadeDoCarro);
        
        Console.WriteLine(velocidadeDeCaminhada);
        velocidadeDeCaminhada -= 2;
        Console.WriteLine(velocidadeDeCaminhada);
        
        Console.WriteLine(dinheiroNaConta);
        dinheiroNaConta -= 30;
        Console.WriteLine(dinheiroNaConta);
        
        Console.ReadLine();
    }
}