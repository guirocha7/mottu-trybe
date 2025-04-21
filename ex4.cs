using System;
using System.Collections.Generic;

class ex4programaclassificacaoalunos
{
    static void Main(string[] args)
    {
        var alunos = new List<(string Nome, double Nota)>();
        string nome;

        Console.WriteLine("Nome do Aluno:");
        while (!string.IsNullOrWhiteSpace(nome = Console.ReadLine()))
        {
            Console.Write("Qual foi a nota do(a) " + nome + ": ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                alunos.Add((nome, nota));
            }
            Console.WriteLine("Nome do Aluno:");
        }

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum dado de aluno foi inserido.");
            return;
        }

        double media = CalcularMedia(alunos);
        Console.WriteLine("Média da turma: " + media);

        Console.WriteLine("Alunos com notas acima da média:");
        foreach (var aluno in alunos)
        {
            if (aluno.Nota > media)
            {
                Console.WriteLine(aluno.Nome);
            }
        }
    }

    static double CalcularMedia(List<(string Nome, double Nota)> alunos)
    {
        double soma = 0;
        foreach (var aluno in alunos)
        {
            soma += aluno.Nota;
        }
        return soma / alunos.Count;
    }
}