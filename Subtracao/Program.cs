using System;

class Subtracao {
  public static void Main (string[] args) {
    Console.WriteLine ("Programa de subtracao!");
    Console.WriteLine("Digite o primeiro número");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int subtracao = num1 - num2;
    Console.WriteLine("O resultado da operação é " + subtracao);
  }
}
