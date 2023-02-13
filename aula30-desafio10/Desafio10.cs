using System;

public class Desafio10
{
    public static void Main(string[] args)
    {
        string senha = "senha123";
        string senhaDigitada;
        int tentativas = 0;
        
        Console.Write("Digite a senha: ");
        senhaDigitada = Console.ReadLine();
        tentativas++;
        
        while(senhaDigitada != senha && tentativas < 3)
        {
            Console.Write("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
            tentativas++;
        }
        
        if(senhaDigitada == senha)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Excesso de tentativas. Sua conta foi bloqueada!");
        }
        
        Console.ReadLine();
    }
}