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
            Console.WriteLine("A palavra não é um palíndromo!");
        }
    }

    static string LimparTexto(string texto)
    {
        return texto.Replace(" ", "").ToLower();
    }

    static bool EhPalindromo(string texto)
    {
        string textolimpo = LimparTexto(texto);

        int inicio = 0;
        int fim = textolimpo.Length - 1;

        while (inicio < fim)
        {
            if (textolimpo[inicio] != textolimpo[fim])
            {
                return false;
            }
            inicio++;
            fim--;
        }

        return true;
    }
}