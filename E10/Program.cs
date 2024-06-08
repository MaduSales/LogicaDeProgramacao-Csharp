// 10) Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente

using System;
using System.Globalization;
using System.Text;

class Operacao
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um outro número");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Agora, escolha uma operação: Adição, Subtração, Multiplicação ou Divisão (não use acentos)");
        string operacao = (Console.ReadLine() ?? string.Empty).ToLowerInvariant(); //Basicamente, para que a string não seja Null e dê erro de exceção, colocamos o operador ?? de coalescência (junção) para que nunca ocorra um Null, e caso a string esteja vazioa, retornará "" (0 caracteres).

        if (operacao == "adicao")
        {
            int resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
        else if (operacao == "subtracao")
        {
            int resultado = num1 - num2;
            Console.WriteLine("A subtração será: " + resultado);
        }
        else if (operacao == "multiplicacao")
        {
            int resultado = num1 * num2;
            Console.WriteLine("O resultado da operação é: " + resultado);
        }
        else if (operacao == "divisao")
        {
            if (num2 != 0)
            {
                double resultado = (double)num1 / num2;
                Console.WriteLine("A operação terá o resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }

        }
        else
        {
            Console.WriteLine("Operação inválida");
        }
    }
}