using System;

public class ForLoops
{
    public static void Main(string[] args)
    {
        /*int contador = 0;
        
        while(contador < 5)
        {
            Console.WriteLine("Pizza!");
            contador++;
        }*/
        
        for(int contador = 0; contador < 5; contador++)
        {
            //Console.WriteLine("Pizza!");
            Console.WriteLine(contador);
        }
        
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Fim do For Loop");
        
        Console.ReadLine();
    }
}