// 8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3).

using System;

class Nota{
    public static void Main(string[] args){
        Console.WriteLine("Insira a nota de um aluno para determinar sua classificação");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 9){
            Console.WriteLine("A nota é: A");
        } else if (nota >= 7 && nota < 9){
            Console.WriteLine("A nota é: B");
        } else if (nota >= 5 && nota < 7){
            Console.WriteLine("A nota é: C");
        } else if (nota >= 3 && nota < 5){
            Console.WriteLine("A nota é: D");
        } else {
            Console.WriteLine("A nota é: E");
        }
    }
}