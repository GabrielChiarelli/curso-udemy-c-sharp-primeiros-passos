using System;

public class CondicoesIf
{
    public static void Main(string[] args)
    {
        int dinheiroDoUsuario = 750;
        
        if(dinheiroDoUsuario > 1500)
        {
            Console.WriteLine("Pode comprar um celular muito bom");
        }
        else if(dinheiroDoUsuario > 1000)
        {
            Console.WriteLine("Pode comprar um celular bom");
        }
        else
        {
            Console.WriteLine("Pode comprar um celular mediano");
        }
        
        Console.ReadLine();
    }
}