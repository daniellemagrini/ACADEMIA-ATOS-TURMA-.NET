/* Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro,
 * solicite-o até que seja. após, informe se ele é par ou impar. 
 * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
 */

int num;
string num_aux;
bool aux_int;

Console.WriteLine("Digite um número inteiro.");
num_aux = Console.ReadLine();


while (aux_int = Int32.TryParse(num_aux, out num) == false)
{
    Console.WriteLine("Número inválido. Favor digitar um número inteiro.");
    num_aux = Console.ReadLine();
}
if (aux_int = Int32.TryParse(num_aux, out num) == true)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num + " é um número par!");
    }
    else
    {
        Console.WriteLine(num + " é um número ímpar!");
    }
}
