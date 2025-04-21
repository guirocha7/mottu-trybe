using System;
using System.Collections.Generic;
using System.Linq;

class JogoDaForca
{
    static void Main()
    {
        List<string> palavras = new List<string> { "mottu"};
        Random random = new Random();
        string palavra = palavras[random.Next(palavras.Count)];

        Console.WriteLine("Teste a sua sorte com o jogo da forca e descubra a palavra");
    }
}