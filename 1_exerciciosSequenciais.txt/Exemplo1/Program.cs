//Exemplo 1 da Aula3 pt1 - Estruturas condicionais.

{
    int num;
    Console.WriteLine("Digite um número:");
    num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        Console.WriteLine("Positivo!");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negativo!");

    }

    else
    {
        Console.WriteLine("Zero!");
    }
}

int num2;
Console.WriteLine("Digite outro número:");
num2 = int.Parse(Console.ReadLine());

if (num2 % 2 == 0)
{
    Console.WriteLine("Número divisível por 2!");
}
if (num2 % 4 == 0)
{
    Console.WriteLine("Número divisível por 2!");
}
if (num2 % 8 == 0)
{
    Console.WriteLine("Número divisível por 2!");
}