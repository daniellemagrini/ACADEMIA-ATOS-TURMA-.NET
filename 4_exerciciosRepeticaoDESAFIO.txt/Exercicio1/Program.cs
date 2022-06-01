/* Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
 * soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n
 */

int n;
int soma = 0;
int soma_total = 0;
int soma_aux;


Console.WriteLine("Digite um número inteiro e positivo.");
n = Convert.ToInt32(Console.ReadLine());

List<int> lista_soma = new List<int>();

for (int i = 1; i <= n; i++)
{
    soma = i + 1;
    Console.WriteLine("\r\n" + i + " + 1 = " + soma);
    lista_soma.Add(soma);
}

soma_total = lista_soma.Sum();
Console.WriteLine("\r\nA soma total é igual a " + soma_total);
