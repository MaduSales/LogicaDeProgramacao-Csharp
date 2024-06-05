using System;
// 3) Escreva um programa que leia dois números inteiros e informe qual deles é o maior. 

class Maior {
  public static void Main (string[] args) {
    Console.WriteLine ("Escreva um número");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escreva outro número");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 < num2){
      Console.WriteLine("O maior número é " + num2);
    } else {
      Console.WriteLine("O maior número é " + num1);
    }
  }
}