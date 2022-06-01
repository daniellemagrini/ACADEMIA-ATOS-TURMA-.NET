/* Fazer um laço (repetição) que fique solicitando números ao usuário.
 * Se o usuário digitar 0 o programa em VS deve parar. 
 * Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
 */

int num;
int cont = 0;

Console.WriteLine("Caso queira encerrar o programa, digite 0, caso contrário digite um número que deseja analisar.");
num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Programa encerrado!");
}
if (num == 2)
{
    Console.WriteLine(num + " é um número par e também um número primo.");
}


for (int i = 1; i <= num; i++)
{

    if (num % i == 0)
    {
        cont++;
    }
}
if (cont == 2 && num % 2 != 0)
{
    Console.WriteLine(num + " é um número ímpar e primo!");
}
else if (cont > 2 && num % 2 != 0)
{
    Console.WriteLine(num + " é um número ímpar e não é um número primo!");
}
else if (cont > 2 && num % 2 == 0)
{
    Console.WriteLine(num + " é um número par e não é um número primo");
}
