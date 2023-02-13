using System;

public class WhileLoops
{
    public static void Main(string[] args)
    {
        int contador = 0;
        
        while(contador < 5)
        {
            Console.WriteLine("Pizza!");
            contador++;
        }
        
        Console.WriteLine("Fim do While Loop");
        
        string nomeDigitado;
        
        Console.Write("Digite o nome secreto: ");
        nomeDigitado = Console.ReadLine();
        
        while(nomeDigitado != "Mario")
        {
            Console.WriteLine("Nome errado!");
            Console.Write("Digite outro nome: ");
            nomeDigitado = Console.ReadLine();
        }
        
        Console.WriteLine("Fim do While Loop");
        
        Console.ReadLine();
    }
}