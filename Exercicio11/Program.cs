// See https://aka.ms/new-console-template for more information

/*
 * 11)  Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
 * representa em relação ao total de eleitores.
**/

Console.WriteLine("Exercício 11 - Aula 2");
Console.WriteLine(" Escreva um algoritmo para ler o número de eleitores de um município,\n" +
    "o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um\n" +
    "representa em relação ao total de eleitores.");

Console.WriteLine("Digite seu município");
string municipio = Console.ReadLine();
Console.WriteLine("Qual o número total de eleitores do município " + municipio + "?");
int total_eleitor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o total de votos brancos deste município");
int total_voto_branco = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o total de votos nulos deste município");
int total_voto_nulo = int.Parse(Console.ReadLine());

int total_voto_valido = total_eleitor - total_voto_branco - total_voto_nulo;

double percent_voto_branco = total_voto_branco * 100 / total_eleitor;
double percent_voto_nulo = total_voto_nulo * 100 / total_eleitor;
double percent_voto_valido = total_voto_valido  * 100 / total_eleitor;

Console.WriteLine("Percentual de votos brancos do município " + municipio + ": " + percent_voto_branco);
Console.WriteLine("Percentual de votos nulos do município " + municipio + ": " + percent_voto_nulo);
Console.WriteLine("Percentual de votos válidos do município " + municipio + ": " + percent_voto_valido);