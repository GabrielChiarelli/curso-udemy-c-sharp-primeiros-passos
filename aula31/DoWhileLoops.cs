using System;

public class DoWhileLoops
{
    public static void Main(string[] args)
    {
        int contador = 0;
        
        do
        {
            Console.WriteLine("Sorvete");
            contador++;
        } while(contador < 5);
        
        Console.WriteLine("Fim do Do While Loop");
        
        Console.ReadLine();
    }
}