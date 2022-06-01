//Crie um algoritmo que verifique se um número informado é par ou impar.

int num;

Console.WriteLine("Digite um número inteiro.");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O número " + num + " é par.");
}
else if (num % 2 != 0)
{
    Console.WriteLine("O número " + num + " é impar.");
}
else
{
    Console.WriteLine("Número inválido!");
}