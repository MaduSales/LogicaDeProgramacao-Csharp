using System;

class Multiplicacao {
  public static void Main (string[] args) {
    Console.WriteLine ("Programa de multiplicação");
    Console.WriteLine("Escreva um número:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escreva um outro número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int resultado = num1 * num2;
    Console.WriteLine("O resultado da operação é: " + resultado);
  }
}