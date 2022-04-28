// See https://aka.ms/new-console-template for more information

/*
 * 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois números quaisquer.
**/

Console.WriteLine("Exercício 1 - Aula 2");
Console.WriteLine("Escreva um programa em C# e no Visual Studio\n"+
"para calcular a média aritmética entre dois números quaisquer.");

float n1;
float n2;
float media_aritmetica;

Console.WriteLine("Digite um número qualquer");
n1 = float.Parse(Console.ReadLine()); // Tudo que vem do teclado, ou seja, tudo que vem do usuário, ele entende como string, então temos que converter
Console.WriteLine("Digite mais um número qualquer");
n2 = float.Parse(Console.ReadLine());
media_aritmetica = (n1 + n2) / 2;

Console.WriteLine("A média aritimética dos dois números digitados é:" + media_aritmetica);

