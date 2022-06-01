/* Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
 * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
 * Ao final, mostre a idade digitada.
*/

int idade = 0;

Console.WriteLine("Qual a sua idade?");
idade = Convert.ToInt32(Console.ReadLine());

while (idade <= 0)
{
    Console.WriteLine("Idade inválida");
    Console.WriteLine("Qual a sua idade?");
    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Sua idade é de " + idade + " anos");