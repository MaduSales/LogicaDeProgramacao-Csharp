using System;

class Soma{
    public static void Main(string[] args){
        Console.WriteLine("Programa de soma");
        Console.Write("Digite um número");
        int numero01 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite outro número");
        int numero02 = Convert.ToInt32(Console.ReadLine());
        int soma = numero01 + numero02;
        Console.Write("O resultado da soma é "+ soma);
    }
}
