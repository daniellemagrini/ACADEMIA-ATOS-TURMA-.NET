// See https://aka.ms/new-console-template for more information

/*
 * 6) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l).
**/

Console.WriteLine("Exercício 6 - Aula 2");
Console.WriteLine("Escreva um programa em C# e no Visual Studio que leia os dados\n" +
    "para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças\n" +
    "e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.");

double IPI_parafuso = 0.05;

Console.WriteLine("Favor digitar o código do parafuso A");
string cod_parafuso_1 = Console.ReadLine();
Console.WriteLine("Favor digitar a quantidade de peças do parafuso A");
int qtd_parafuso_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Favor digitar o valor unitário do parafuso A");
float vl_un_parafuso_1 = float.Parse(Console.ReadLine());

Console.WriteLine("Favor digitar o código do parafuso B");
string cod_parafuso_2 = Console.ReadLine();
Console.WriteLine("Favor digitar a quantidade de peças do parafuso B");
int qtd_parafuso_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Favor digitar o valor unitário do parafuso B");
float vl_un_parafuso_2 = float.Parse(Console.ReadLine());

double vl_bruto_parafuso_1 = (vl_un_parafuso_1 * qtd_parafuso_1 + (vl_un_parafuso_1 * qtd_parafuso_1 * IPI_parafuso));
double vl_bruto_parafuso_2 = (vl_un_parafuso_2 * qtd_parafuso_2 + (vl_un_parafuso_2 * qtd_parafuso_2 * IPI_parafuso));

Console.WriteLine("O valor do parafuso A acrescido de IPI é " + vl_bruto_parafuso_1 + " e o B é " + vl_bruto_parafuso_2);