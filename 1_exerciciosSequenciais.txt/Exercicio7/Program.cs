// See https://aka.ms/new-console-template for more information

/*
 * 7) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
 * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l).
**/

Console.WriteLine("Exercício 7 - Aula 2");
Console.WriteLine("Escreva um programa em C# e no Visual Studio\n" +
    "que leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas\n" +
    "e o percentual que ganha sobre o total de vendas.\n" +
    "Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");

Console.WriteLine("Favor digitar o número do vendedor");
int n_vendedor = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o salário fixo desse vendedor?");
float sal_fixo_vendedor = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o total de vendas dele?");
int total_vendas__vendedor = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o percentual que ganha sobre o total das vendas?");
double perc_comissao_vendedor = double.Parse(Console.ReadLine());

double perc_comissao_vendedor1 = perc_comissao_vendedor / 100;
double comissao_vendedor = total_vendas__vendedor * perc_comissao_vendedor1;

double sal_total_vendedor = sal_fixo_vendedor + comissao_vendedor;

Console.WriteLine("O salário total do vendedor de número " + n_vendedor + " será " + sal_total_vendedor);

