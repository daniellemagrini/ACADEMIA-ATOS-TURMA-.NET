// See https://aka.ms/new-console-template for more information

/*
 * 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.
 * Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
 * preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do
 * salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
 * vendidas pelo vendedor, calcule e mostre: o salário do empregado
**/

Console.WriteLine("Exercício 13 - Aula 2");
Console.WriteLine(" Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.\n" +
    "Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre\n" +
    "o preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor\n" +
    "do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas vendidas\n" +
    "pelo vendedor, calcule e mostre: o salário do empregado");

double salario_minimo = 1212;

Console.WriteLine("Qual o preço de custo dessa bicicleta?");
double custo_bicicleta = double.Parse(Console.ReadLine());
Console.WriteLine("Quantas dessas foram vendidas pelo vendedor?");
double qtde_vendida = double.Parse(Console.ReadLine());

double preco_venda_bicicleta = custo_bicicleta + (custo_bicicleta * 0.5);
double comissao_vendedor = qtde_vendida * preco_venda_bicicleta * 0.15;
double salario_total = salario_minimo * 2 + comissao_vendedor;

Console.WriteLine("O salário final é: " + salario_total);
