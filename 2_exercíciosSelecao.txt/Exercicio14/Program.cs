/* Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
 * link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
 * do arquivo usando este link (em minutos).
 */

double tamanho;
double velocidade;
double tempo;

Console.WriteLine("Qual o tamanho do arquivo para download (em MB)?");
tamanho = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a velocidade (em Mbps)?");
velocidade = double.Parse(Console.ReadLine());

tempo = (tamanho / velocidade) *60;
Console.WriteLine("Tempo aproximado de donwload: " + tempo + " minutos");
