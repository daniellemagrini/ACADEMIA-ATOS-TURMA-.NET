// See https://aka.ms/new-console-template for more information

/*
 * 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
 *    A fórmula da conversão é F=(9*C+160)/5.
**/

Console.WriteLine("Exercício 8 - Aula 2");
Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.\n" +
    "A fórmula da conversão é F = (9 * C + 160) / 5.");

Console.WriteLine("Digite a temperatura que deseja converter");
float temp_celsius  = float.Parse(Console.ReadLine());

float temp_fahrenheit = (9 * temp_celsius + 160) / 5;

Console.WriteLine("A temperatura correspondente, em fahrenheit é: " + temp_fahrenheit);
