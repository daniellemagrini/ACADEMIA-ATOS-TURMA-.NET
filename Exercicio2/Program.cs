// See https://aka.ms/new-console-template for more information

/*
 * 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois números quaisquer.
**/

Console.WriteLine("Exercício 2 - Aula 2");
Console.WriteLine("Escreva um programa em C# e no Visual Studio\n" +
    "para calcular a média aritmética entre quatro números quaisquer.");

float n1;
float n2;
float n3;
float n4;
float media_aritmetica;

Console.WriteLine("Digite um número qualquer");
n1 = float.Parse(Console.ReadLine()); // Tudo que vem do teclado, ou seja, tudo que vem do usuário, ele entende como string, então temos que converter
Console.WriteLine("Digite mais um número qualquer");
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite mais um número qualquer");
n3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite mais um número qualquer");
n4 = float.Parse(Console.ReadLine());
media_aritmetica = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine("A média aritimética dos quatro números digitados é:" + media_aritmetica);