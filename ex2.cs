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
            }
            else if (tentativa < numeroAdivinhar)
            {
                Console.WriteLine("O número é maior que sua tentativa.");
            }
            else
            {
                Console.WriteLine("O número é menor que sua tentativa.");
            }

            int diferenca = Math.Abs(tentativa - numeroAdivinhar);

            if (!adivinhou)
            {
                if (diferenca > 100)
                {
                    Console.WriteLine("Você está muito distante.");
                }
                else if (diferenca > 50)
                {
                    Console.WriteLine("Você está distante.");
                }
                else
                {
                    Console.WriteLine("Você está perto.");
                }
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}