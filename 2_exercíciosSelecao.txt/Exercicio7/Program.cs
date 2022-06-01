/*Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
 * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
 * exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
 */


string frase;
string palavra;

Console.WriteLine("Escreva uma frase");
frase = Console.ReadLine();
Console.WriteLine("Escreva uma palavra de pesquisa");
palavra = Console.ReadLine();


if (frase.Contains(palavra))
{
    Console.WriteLine("A palavra encontra-se na frase");
}
else
{
    Console.WriteLine("A palavra não se encontra na frase");
}