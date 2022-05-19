/*Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
 * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
 * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
 * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
 * total de vendas. 
*/

int codigo;
string nome;
double salario_base;
double total_vendas;
double salario_final;

Console.WriteLine("Qual o Código do colaborador?");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o nome do colaborador?");
nome = Console.ReadLine();
Console.WriteLine("Qual o salário base do colaborador?");
salario_base = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual o total de vendas do colaborador?");
total_vendas = Convert.ToDouble(Console.ReadLine());

if (total_vendas > 500)
{
    salario_final = salario_base + (total_vendas * 0.05);
    Console.WriteLine("Seu salário final é de: " + salario_final);
}
else if (total_vendas > 1000)
{
    salario_final = salario_base + (total_vendas * 0.07);
    Console.WriteLine("Seu salário final é de: " + salario_final);
}
else if (total_vendas > 5000)
{
    salario_final = salario_base + (total_vendas * 0.1);
    Console.WriteLine("Seu salário final é de: " + salario_final);
}
else
{
    Console.WriteLine("Seu salário final é de: " + salario_base);
}