using System;

class Ex2JogoAdivinhacao
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAdivinhar = random.Next(1, 1001);

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 1000.");

        bool adivinhou = false;

        while (!adivinhou)
        {
            Console.Write("Digite sua tentativa: ");
            int tentativa = int.Parse(Console.ReadLine());

            
        }
    }
}