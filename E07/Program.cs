// 7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). 

using System;

class Idade{
    public static void Main(string[] args){
        Console.WriteLine("Informe a sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12){
            Console.WriteLine("Você deve ser uma criança! Continue estudando hein :)");
        } else if (idade >= 13 && idade <= 17){
            Console.WriteLine("Você deve ser um adolescente! Não desista dos seus estudos :)");
        } else if (idade >= 18 && idade <= 59){
            Console.WriteLine("Você já deve ser um adulto! Ainda há tempo de estudar e aprender :)");
        } else {
            Console.WriteLine("Você deve ser uma pessoa idosa... aposto que vive uma vida linda, você ainda pode estudar, hein? :)");
        }
    }
}