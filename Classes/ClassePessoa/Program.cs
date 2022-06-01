// Chamando aqui (No main = principal) a classe pessoa.

using ClassePessoa;

string nome;
int idade;
double altura;
double peso;
string cor_cabelo;
string cor_olhos;

Console.WriteLine("Digite o nome da pessoa");
nome = Console.ReadLine();
Console.WriteLine("Qual a idade dessa pessoa?");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a altura?");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o peso?");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a cor do cabelo?");
cor_cabelo = Console.ReadLine();
Console.WriteLine("Qual a cor dos olhos?");
cor_olhos = Console.ReadLine();

Pessoa p1 = new Pessoa(nome, idade, altura, peso, cor_cabelo, cor_olhos);
p1.apresenta_info_pessoa();

