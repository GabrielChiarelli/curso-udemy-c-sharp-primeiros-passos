using System;

public class OperadoresLogicos
{
    public static void Main(string[] args)
    {
        bool farolFechado = true;
        bool ruaVazia = true;
        
        bool gostaDeMassa = false;
        bool gostaDeQueijo = false;
        
        if(farolFechado && ruaVazia)
        {
            Console.WriteLine("Pode atravessar");
        }
        else
        {
            Console.WriteLine("Espere mais um pouco");
        }
        
        if(gostaDeMassa == true || gostaDeQueijo == true)
        {
            Console.WriteLine("Coma uma pizza");
        }
        
        Console.ReadLine();
    }
}