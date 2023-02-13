using System;

public class Desafio05
{
    public static void Main(string[] args)
    {
        double numero1;
        double numero2;
        
        Console.Write("Digite um numero: ");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        numero2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine(numero1 + numero2);
        
        Console.ReadLine();
    }
}