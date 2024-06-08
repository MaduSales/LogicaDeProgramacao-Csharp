// 14) Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.

using System;

class PositivoNegativo{
    public static void Main(string[] args){
        Console.WriteLine("Digite um número negativo ou positivo");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0){
            double resultado = Math.Sqrt(numero); //Essa é a função raiz quadrada no C#
            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        } else if (numero < 0){
            int resultado = numero * numero;
            Console.WriteLine($"O quadrado de {numero} é {resultado}");
        } else {
            Console.WriteLine("Inválido");
        }
    }
}