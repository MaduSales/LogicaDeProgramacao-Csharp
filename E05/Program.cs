// Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). 

using System;

class MediaDeAluno
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos calcular a média deste aluno para descobrir se ele foi aprovado ou não");
        Console.WriteLine("Informe a primeira nota: ");
        int nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        int nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota: ");
        int nota3 = Convert.ToInt32(Console.ReadLine());

        int media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("A nota é " + media);
            Console.WriteLine("Aluno aprovado");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("A nota é " + media);
            Console.WriteLine("Aluno em recuperação");
        }
        else
        {
            Console.WriteLine("A nota é " + media);
            Console.WriteLine("Aluno reprovado");
        }
    }
}