using System;

public class Arrays
{
    public static void Main(string[] args)
    {
        /*string nome1 = "Mario";
        string nome2 = "Luigi";
        string nome3 = "Toad";
        
        Console.WriteLine (nome1);
        Console.WriteLine (nome2);
        Console.WriteLine (nome3);*/
        
        string[] nomes = {"Mario", "Luigi", "Toad"};
        
        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);
        
        nomes[0] = "Gabriel";
        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes.Length);
        
        int[] numeros = new int[4];
        
        numeros[0] = 10;
        numeros[1] = 7;
        numeros[2] = 45;
        numeros[3] = 22;
        
        Console.WriteLine(numeros[2]);
        
        Console.ReadLine();
    }
}