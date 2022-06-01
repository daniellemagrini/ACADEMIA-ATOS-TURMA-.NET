/* Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
 * O programa deve mostrar os dados do atleta mais novo e mais alto.
 */

string nome1;
int idade1;
float altura1;
string nome2;
int idade2;
float altura2;

Console.WriteLine("Qual o nome do atleta 1?");
nome1 = Console.ReadLine();
Console.WriteLine("Qual a idade do atleta 1?");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura do atleta 1?");
altura1 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual o nome do atleta 2?");
nome2 = Console.ReadLine();
Console.WriteLine("Qual a idade do atleta 2?");
idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura do atleta 2?");
altura2 = float.Parse(Console.ReadLine());

if (idade1 < idade2 && altura1 > altura2)
{
    Console.WriteLine("O aluno mais novo e mais alto é o atleta 1:");
    Console.WriteLine("Nome: " +nome1);
    Console.WriteLine("Idade: " +idade1);
    Console.WriteLine("Altura: " +altura1);
}
else if (idade1 > idade2 && altura1 < altura2)
{
    Console.WriteLine("O aluno mais novo e mais alto é o atleta 2:");
    Console.WriteLine("Nome: " + nome2);
    Console.WriteLine("Idade: " + idade2);
    Console.WriteLine("Altura: " + altura2);
}
else if (idade1 < idade2 && altura1 < altura2)
{
    Console.WriteLine("O aluno mais novo é o atleta 1 e o mais alto é o atleta 2:");
    Console.WriteLine("Nome atleta 1: " + nome1);
    Console.WriteLine("Idade atleta 1: " + idade1);
    Console.WriteLine("Altura atleta 1: " + altura1);

    Console.WriteLine("Nome atleta 2: " + nome2);
    Console.WriteLine("Idade atleta 2: " + idade2);
    Console.WriteLine("Altura atleta 2: " + altura2);
}
else if (idade1 > idade2 && altura1 > altura2)
{
    Console.WriteLine("O aluno mais novo é o atleta 2 e o mais alto é o atleta 1:");
    Console.WriteLine("Nome atleta 1: " + nome1);
    Console.WriteLine("Idade atleta 1: " + idade1);
    Console.WriteLine("Altura atleta 1: " + altura1);

    Console.WriteLine("Nome atleta 2: " + nome2);
    Console.WriteLine("Idade atleta 2: " + idade2);
    Console.WriteLine("Altura atleta 2: " + altura2);
}