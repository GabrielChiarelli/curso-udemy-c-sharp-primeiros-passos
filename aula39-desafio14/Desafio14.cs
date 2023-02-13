using System;

public class Desafio14
{
    public static void Main(string[] args)
    {
        int numero;
        
        Console.Write("Digite um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("A tabuada do numero " + numero + ":");
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine(numero + "x" + i + " = " + numero * i);
        }
        
        Console.ReadLine();
    }
}