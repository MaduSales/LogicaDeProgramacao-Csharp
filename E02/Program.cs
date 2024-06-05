using System;
// 2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. 

class PositivoNegativo {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número para saber se é positivo ou negativo");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 0){
      Console.WriteLine("O número é negativo");
    } else if (numero > 0){
      Console.WriteLine("O número é positivo");
    } else{
      Console.WriteLine("O número é zero");
    }
  }
}