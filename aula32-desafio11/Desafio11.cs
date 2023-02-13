using System;

public class Desafio11
{
    public static void Main(string[] args)
    {
        string senha = "senha123";
        string senhaDigitada;
        int tentativas = 0;
        
        do
        {
            Console.Write("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
            tentativas++;
        } while(senhaDigitada != senha && tentativas < 3);
        
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