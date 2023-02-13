using System;

public class VariavelIntELong
{
    public static void Main(string[] args)
    {
        int idade = 23;
        int multiplicacao = 14 * 2;
        int numeroGrande = 2147483647;
        
        long numeroMuitoGrande = 2147483648;
        numeroMuitoGrande += 1;
        
        //Console.WriteLine(idade);
        //Console.WriteLine(idade + 10);
        //Console.WriteLine(idade);
        //idade = idade + 10;
        //idade += 10;
        //Console.WriteLine(idade);
        //Console.WriteLine(multiplicacao);
        //Console.WriteLine(numeroGrande);
        Console.WriteLine(numeroMuitoGrande);
        
        Console.ReadLine();
    }
}