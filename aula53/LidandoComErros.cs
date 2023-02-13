using System;

public class LidandoComErros
{
    public static void Main(string[] args)
    {
        try
        {
            int numero1;
            int numero2;
            
            Console.Write("Digite um valor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine((numero1 / numero2));
        }
        /*catch(Exception erro)
        {
            Console.WriteLine(erro.Message);
        }*/
        catch(DivideByZeroException)
        {
            Console.WriteLine("Impossivel dividir por 0!");
        }
        catch(FormatException)
        {
            Console.WriteLine("Valor invalido!");
        }
        finally
        {
            Console.WriteLine("Cheguei ao fim :)");
        }
        
        Console.ReadLine();
    }
}