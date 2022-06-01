// See https://aka.ms/new-console-template for more information

/*
 * 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
 * para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
 * realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
 * notas de menor valor fossem distribuídas em número mínimo possível. 
 * Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
 * três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
 * Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
 * de acordo com o critério da “distribuição ótima”.
**/

Console.WriteLine("Exercício 10 - Aula 2");
Console.WriteLine("Um programa para gerenciar os saques de um caixa eletrônico deve possuir\n" +
    "algum mecanismo para decidir o número de notas de cada valor que deve ser disponibilizado\n" +
    "para o cliente que realizou o saque.Um possível critério seria o da “distribuição ótima”\n" +
    "no sentido de que as notas de menor valor fossem distribuídas em número mínimo possível.\n" +
    "Por exemplo, se a quantia solicitada fosse R$ 87, 00 o programa deveria indicar\n" +
    "uma nota de R$ 50, 00, três notas de R$ 10, 00, uma nota de R$ 5, 00 e duas notas de R$ 1, 00.\n" +
    "Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas\n" +
    "de acordo com o critério da “distribuição ótima”.");

Console.WriteLine("Qual valor deseja sacar?");
int valor = int.Parse(Console.ReadLine());

int resto_200 = valor % 200;
int nota_200 = (valor - resto_200) / 200;
int valor2 = valor - 200 * nota_200;

int resto_100 = valor2 % 100;
int nota_100 = (valor2 - resto_100) / 100;
int valor3 = valor2 - 100 * nota_100;

int resto_50 = valor3 % 50;
int nota_50 = (valor3 - resto_50) / 50;
int valor4 = valor3 - 50 * nota_50;

int resto_20 = valor4 % 20;
int nota_20 = (valor4 - resto_20) / 20;
int valor5 = valor4 - 20 * nota_20;

int resto_10 = valor5 % 10;
int nota_10 = (valor5 - resto_10) / 10;
int valor6 = valor5 - 10 * nota_10;

int resto_5 = valor6 % 5;
int nota_5 = (valor6 - resto_5) / 5;
int valor7 = valor6 - 5 * nota_5;

int nota_2 = valor7 / 2;

Console.WriteLine("Total de notas de 200 reais: " + nota_200);
Console.WriteLine("Total de notas de 100 reais: " + nota_100);
Console.WriteLine("Total de notas de 50 reais: " + nota_50);
Console.WriteLine("Total de notas de 20 reais: " + nota_20);
Console.WriteLine("Total de notas de 10 reais: " + nota_10);
Console.WriteLine("Total de notas de 5 reais: " + nota_5);
Console.WriteLine("Total de notas de 2 reais: " + nota_2);



