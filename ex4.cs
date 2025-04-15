using System;
using System.Collections.Generic;

class ProgramaClassificacaoAlunos
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
}