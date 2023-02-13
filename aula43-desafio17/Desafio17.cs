using System;

public class Desafio17
{
    public static void Main(string[] args)
    {
        int[] numeros = {10, 5, 24, 41, 50};
        
        Console.WriteLine("Numeros Pares: ");
        foreach(int numero in numeros)
        {
            if(numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }
        
        Console.ReadLine();
    }
}