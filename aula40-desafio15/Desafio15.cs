using System;

public class Desafio15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tabuadas de 1 a 10:");
        for(int primeiroNumero = 1; primeiroNumero < 11; primeiroNumero++)
        {
            for(int segundoNumero = 1; segundoNumero < 11; segundoNumero++)
            {
                Console.WriteLine(primeiroNumero + "x" + segundoNumero + " = " + primeiroNumero * segundoNumero);
            }
        }
        
        Console.ReadLine();
    }
}