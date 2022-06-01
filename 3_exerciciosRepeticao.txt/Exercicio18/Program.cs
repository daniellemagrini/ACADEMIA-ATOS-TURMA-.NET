/* Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
 * elevada a um expoente qualquer, ou seja, NM.
 */

Random num_base = new Random();
Random num_elevado = new Random();

int n_base = num_base.Next(1,100);
int n_elevado = num_elevado.Next(1,10);

Console.WriteLine(n_base);
Console.WriteLine(n_elevado);

double resultado = Math.Pow(n_base, n_elevado);

Console.WriteLine(n_base + " elevado a " + n_elevado + " = " + resultado);
