using System;

public class ForeachLoops
{
    public static void Main(string[] args)
    {
        string[] nomes = {"Mario", "Luigi", "Toad"};
        
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome.ToUpper());
        }
        
        int[] numeros = {1, 2, 3, 4, 5};
        
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero * 2);
        }
        
        Console.WriteLine(numeros[0] * 2);
        
        Console.ReadLine();
    }
}