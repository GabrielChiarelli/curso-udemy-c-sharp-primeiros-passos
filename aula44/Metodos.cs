using System;

public class Metodos
{
    public static void Main(string[] args)
    {
        /*SaudarUsuario();
        SaudarUsuario();
        SaudarUsuario();*/
        
        FazerConta();
        FazerConta();
        
        Console.ReadLine();
    }
    
    private static void SaudarUsuario()
    {
        Console.WriteLine("Ola, usuario! Como vai?");
    }
    
    private static void FazerConta()
    {
        int numero1;
        int numero2;
        
        Console.Write("Digite um numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Soma = " + (numero1 + numero2));
    }
}