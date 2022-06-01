/*Escrever um algoritmo para ler quatro valores inteiros,
 * calcular a sua média, e escrever na tela os que são superiores à média.
 */

int num1;
int num2;
int num3;
int num4;
float media;

Console.WriteLine("Digite um número inteiro");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um segundo número inteiro");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um terceiro número inteiro");
num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um quarto número inteiro");
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

if (num1 > media)
{
    Console.WriteLine("O primeiro número digitado é maior que a média");
}
if (num2 > media)
{
    Console.WriteLine("O segundo número digitado é maior que a média");
}
if (num3 > media)
{
    Console.WriteLine("O terceiro número digitado é maior que a média");
}
if (num4 > media)
{
    Console.WriteLine("O quarto número digitado é maior que a média");
}
