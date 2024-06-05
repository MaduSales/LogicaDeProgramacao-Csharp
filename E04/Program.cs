using System;
// 4) Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado. 

class Triangulo {
  public static void Main (string[] args) {
    Console.WriteLine ("Escreva o valor de um lado do triângulo:");
    int lado1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Escreva o valor do segundo lado do triângulo:");
    int lado2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Escreva o último valor lado do triângulo:");
    int lado3 = Convert.ToInt32(Console.ReadLine());

    if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1){
      Console.WriteLine("É um triângulo");
    } else {
      Console.WriteLine("Não é um triângulo");
    }
  }
}