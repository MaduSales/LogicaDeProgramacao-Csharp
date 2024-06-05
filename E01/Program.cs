using System;
// 1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar. 

class ParOuImpar {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número para saber se é par ou ímpar");
    int num = Convert.ToInt32(Console.ReadLine());
    int resultado = num % 2;
    if (resultado == 0){
      Console.WriteLine("O número é par");
    } else{
      Console.WriteLine("O número é ímpar");
    }
    
  }
}