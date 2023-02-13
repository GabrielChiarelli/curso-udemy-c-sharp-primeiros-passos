using System;

public class JogoDeAdivinhacao
{
    public static void Main(string[] args)
    {
        int numeroSecreto = 123;
        int numeroDigitado;
        int tentativas = 0;
        
        Console.Write("Adivinhe o numero secreto: ");
        numeroDigitado = Convert.ToInt32(Console.ReadLine());
        tentativas++;
        
        while(numeroDigitado != numeroSecreto)
        {
            Console.Write("ERROU! Tente novamente: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());
            tentativas += 1;
        }
        
        Console.WriteLine("Muito bem! Voce adivinhou o numero secreto em " + tentativas + " tentativas.");
        
        Console.ReadLine();
    }
}