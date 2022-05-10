//Exercício Desafio String!

/*Fazer um programa em C# que receba o nome completo de uma pessoa e exiba, em maiúsculo,
o primeiro nome e último sobrenome e também seu nome completo abreviado.
*/

string nome;
string primeiro_nome;
string ultimo_nome;

Console.WriteLine("Qual seu nome completo (Sem abreviações)?");
nome = Console.ReadLine();

string[] palavras = nome.Split(" ");

primeiro_nome = palavras[0];
ultimo_nome = palavras[palavras.Length - 1];

Console.WriteLine("Seu primeiro nome é: " + primeiro_nome.ToUpper());
Console.WriteLine("Seu último sobrenome é: " + ultimo_nome.ToUpper());



