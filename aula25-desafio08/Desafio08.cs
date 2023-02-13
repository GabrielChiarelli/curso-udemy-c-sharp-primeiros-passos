using System;

public class Desafio08
{
    public static void Main(string[] args)
    {
        double limiteDaVelocidade = 45.0;
        double velocidadeDoCarro;
        
        Console.Write("Digite a velocidade do carro: ");
        velocidadeDoCarro = Convert.ToDouble(Console.ReadLine());
        
        if(velocidadeDoCarro > limiteDaVelocidade)
        {
            Console.WriteLine("Acima do limite. Voce foi MULTADO!");
        }
        else
        {
            Console.WriteLine("Dentro do limite. Pode passar.");
        }
        
        Console.ReadLine();
    }
}