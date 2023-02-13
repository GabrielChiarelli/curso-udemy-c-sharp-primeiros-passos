using System;

public class Desafio13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Numeros pares entre 1 e 100: ");
        
        for(int i = 1; i < 101; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        Console.ReadLine();
    }
}