/* Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
 * sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
 * números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
 * que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.
 */

int n;
int fibonacci = 1;
int n1 = 0;
int n2 = 1;
int aux;

Console.WriteLine("Digite um número");
n = Convert.ToInt32(Console.ReadLine());

List<int> lista_fibonacci = new List<int>();
lista_fibonacci.Add(0);
lista_fibonacci.Add(1);

for (int i = 2; i < n; i++)
{
    aux = n1;
    n1 = n2;
    n2 = aux + n2;
    lista_fibonacci.Add(n2);
}

Console.WriteLine("Segue os " + n + " primeiros números da sequencia de Fibonacci:");

foreach (int i in lista_fibonacci)
{
    Console.WriteLine(i);
}
