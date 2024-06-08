// 15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria:

// Abaixo do peso: IMC < 18.5

// Peso normal: 18.5 <= IMC < 24.9

// Sobrepeso: 25 <= IMC < 29.9

// Obesidade grau I: 30 <= IMC < 34.9

// Obesidade grau II: 35 <= IMC < 39.9

// Obesidade grau III: IMC >= 40

using System;

class IMC
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu IMC");
        double imc = Convert.ToDouble(Console.ReadLine());

        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Você está no peso normal");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Você está com sobrepeso");
        }
        else if (imc >= 30 && imc < 34.9)
        {
            Console.WriteLine("Você está com obesidade grau 1");
        }
        else if (imc >= 35 && imc < 39.9)
        {
            Console.WriteLine("Você está com obesidade grau 2");
        }
        else
        {
            Console.WriteLine("Você está com obesidade grau 3");
        }
    }
}