using System;

class JogoAdivinhacao
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAdivinhar = random.Next(1, 1001);

         Console.WriteLine("Exercício 2:Jogo de Adivinhação");
        Console.WriteLine("Você vai tentar adivinhar um número entre 1 e 1000.");


        bool adivinhou = false;

        while (!adivinhou)
        {
            Console.Write("Teste a sua sorte, digite sua tentativa: ");
            int tentativa = int.Parse(Console.ReadLine());

            if (tentativa == numeroAdivinhar)
            {
                Console.WriteLine("Parabéns! Você adivinhou o número!");
                adivinhou = true;