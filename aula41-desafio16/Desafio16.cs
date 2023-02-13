using System;

public class Desafio16
{
    public static void Main(string[] args)
    {
        int[] numeros = {3, 55, 7, 1, 62};
        int menor;
        int maior;
        
        menor = numeros[0];
        maior = numeros[0];
        
        for(int posicaoAtual = 0; posicaoAtual < numeros.Length; posicaoAtual++)
        {
            if(numeros[posicaoAtual] < menor)
            {
                menor = numeros[posicaoAtual];
            }
            else if(numeros[posicaoAtual] > maior)
            {
                maior = numeros[posicaoAtual];
            }
        }
        
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Maior: " + maior);
        
        Console.ReadLine();
    }
}