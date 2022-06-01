// See https://aka.ms/new-console-template for more information

/*
 * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l).
**/

Console.WriteLine("Exercício 5 - Aula 2");
Console.WriteLine("Escreva um programa em C# e no Visual Studio\n" +
    "para calcular o consumo médio de um automóvel (medido em Km / l),\n" +
    "sendo que são conhecidos a distância total percorrida e o volume de combustível\n" +
    "consumido para percorrê - la(medido em l).");

//Consumo médio = Distancia percorrida dividido pelo volume de combustível usado

Console.WriteLine("Qual a distancia percorrida?");
float dist_percorrida = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o volume de combustível utilizado?");
float vol_combustivel = float.Parse(Console.ReadLine());

float consumo_medio = dist_percorrida / vol_combustivel;

Console.WriteLine("Seu consumo médio foi de:" + consumo_medio);


