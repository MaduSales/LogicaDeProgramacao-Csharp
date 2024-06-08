// 11) Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive).
using System;

class Intervalo{
    public static void Main(string[] args){
        Console.WriteLine("Digite um número para ver se ele faz parte do intervalo de números inteiros");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 10){
            Console.WriteLine("Desculpe, mas esse número não faz parte... tente de novo.");
        } else if (numero >= 10 && numero <= 20){
            Console.WriteLine("Parabéns! Você acertou!");
        } else{
             Console.WriteLine("Desculpe, mas esse número não faz parte... tente de novo.");
        }
    }
}