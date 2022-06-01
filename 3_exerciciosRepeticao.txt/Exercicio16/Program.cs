/* Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
 * multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 (N*3; N*3*3; N*3*3*3; etc).
 */


Random n = new Random();
int num = n.Next(0,50);

Console.WriteLine(num);

int multiplicacao = num * 3;

while (multiplicacao < 250)
{
    multiplicacao = multiplicacao * 3;
}

Console.WriteLine("Multiplicação: " + multiplicacao);


