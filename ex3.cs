using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Verificação de palíndromo: Digite uma palavra.....");
        string input = Console.ReadLine();

        if (EhPalindromo(input))
        {
            Console.WriteLine("A palavra é um palíndromo!");
        }
        else
        {
            Console.WriteLine("A palavra não é um palíndromo.");
        }
    }

