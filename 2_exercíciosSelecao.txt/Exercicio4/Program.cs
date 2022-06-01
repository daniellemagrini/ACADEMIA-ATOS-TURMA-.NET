/*Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
 * e o valor por hora recebido por cada um deles. 
 * Mostrar na tela qual dos professores tem o maior salário total.
 */

string nome_prof_1;
string nome_prof_2;
float qtde_prof_1;
float qtde_prof_2;
float valor_prof_1;
float valor_prof_2;

Console.WriteLine("Qual o nome completo do professor?");
nome_prof_1 = Console.ReadLine();
Console.WriteLine("Quantidade de horas aula dadas por este professor?");
qtde_prof_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor recebido por hora?");
valor_prof_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o nome completo do segundo professor?");
nome_prof_2 = Console.ReadLine();
Console.WriteLine("Quantidade de horas aula dadas por este professor?");
qtde_prof_2 = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor recebido por hora?");
valor_prof_2 = float.Parse(Console.ReadLine());

float salario_prof_1 = qtde_prof_1 * valor_prof_1;
float salario_prof_2 = qtde_prof_2 * valor_prof_2;

if (salario_prof_1 > salario_prof_2)
{
    Console.WriteLine("O professor com maior salário é o " + nome_prof_1);
}
else if (salario_prof_1 < salario_prof_2)
{
    Console.WriteLine("O professor com maior salário é o " + nome_prof_2);
}
else
{
    Console.WriteLine("Os salários são iguais");
}