/* Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero).
 * Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).
 */

//PROGRAMA NÃO FINALIZADO!

string n;
int qtde_numeros;
List<string> lista_numeros = new List<string>();

Console.WriteLine("Fazer uma lista de números inteiros positivos terminada pelo número 0 (zero).");
Console.WriteLine("Quantos números deseja digitar?");
qtde_numeros = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtde_numeros; i++)
{
    Console.WriteLine("Digite um número.");
    n = Console.ReadLine();

    if 
    {
        Console.WriteLine("Número inválido. Não foi considerado.");
    }
    else
    {
        tamanho_n = n.Length;
        Console.WriteLine(tamanho_n);
        Console.WriteLine("Número salvo.");
        lista_numeros.Add(n);
    }
}

foreach (var numero in lista_numeros)
{
    Console.WriteLine(numero.Contains("0"));
    
}
