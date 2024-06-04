using System;

class Divisao{
  public static void Main(string[] args){
    Console.WriteLine("Programa de divisão!");
    Console.WriteLine("Digite um número:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int divisao = num1 / num2;
    Console.WriteLine("O resultado da operação é: " + divisao);
    
  }
}