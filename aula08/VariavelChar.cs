using System;

public class VariavelChar
{
    public static void Main(string[] args)
    {
        char letra = 'A';
        char numero = '7';
        
        //Console.WriteLine(Char.IsLetter(letra));
        //Console.WriteLine(Char.IsNumber(numero));
        //Console.WriteLine(Char.IsUpper(letra));
        //Console.WriteLine(Char.IsLower(letra));
        Console.WriteLine(Char.ConvertFromUtf32(51));
        
        Console.ReadLine();
    }
}