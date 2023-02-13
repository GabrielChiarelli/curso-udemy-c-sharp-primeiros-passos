using System;

public class Desafio23
{
    public static void Main(string[] args)
    {
        int[] numeros = {3, 7, 12, 21, 38};
        
        Console.WriteLine("Temos " + VerificarImpares(numeros) + " numeros impares.");
        
        Console.ReadLine();
    }
    
    private static int VerificarImpares(int[] numerosParaVerificar)
    {
        int quantidadeDeImpares = 0;
        
        for(int i = 0; i < numerosParaVerificar.Length; i++)
        {
            if(numerosParaVerificar[i] % 2 != 0)
            {
                quantidadeDeImpares += 1;
            }
        }
        
        return quantidadeDeImpares;
    }
}