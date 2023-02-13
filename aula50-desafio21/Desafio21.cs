using System;

public class Desafio21
{
    public static void Main(string[] args)
    {
        double numero1;
        double numero2;
        
        Console.Write("Digite um numero: ");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        numero2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("A media desses 2 numeros e: " + CalcularMedia(numero1, numero2));
        
        Console.ReadLine();
    }
    
    private static double CalcularMedia(double numero1, double numero2)
    {
        double media = (numero1 + numero2) / 2;
        return media;
    }
}