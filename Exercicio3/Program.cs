/*
 * 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois números quaisquer.
**/

Console.WriteLine("Exercício 3 - Aula 2");
Console.WriteLine("Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,\n" +
    "para trocar entre si os valores de duas variáveis A e B.");


Console.WriteLine("Digite uma palavra qualquer");
string var1 = Console.ReadLine();
Console.WriteLine("Digite outra palavra qualquer");
string var2 = Console.ReadLine();

Console.WriteLine("Primeira palavra digitada:" + var1);
Console.WriteLine("Segunda palavra digitada:" + var2);

string tmp = var1; // Variável temporária(tmp) recebe o valor da variável 1
var1 = var2;
var2 = tmp;

Console.WriteLine("Alterando a ordem das palavras, sua primeira e segunda palavra respectivamente palavra será " + var1);
Console.WriteLine("e sua segunda paçavra será " + var2);






