using System;

public class Desafio06
{
    public static void Main(string[] args)
    {
        int numero;
        
        Console.Write("Digite um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        /* %
        10 / 2 = 5 % = 0
        5 / 2 = 2.5 % = 1
        */
        
        if(numero % 2 == 0)
        {
            Console.WriteLine("O numero " + numero + " e par");
        }
        else
        {
            Console.WriteLine("O numero " + numero + " e impar");
        }

        Console.ReadLine();
    }
}