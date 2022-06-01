/* Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
 * nesse intervalo. 
 */

int soma_par = 0;

Random inferior = new Random();
Random superior = new Random();

int n_inferior = inferior.Next(0,20);
int n_superior = superior.Next(21,100);

Console.WriteLine(n_inferior);
Console.WriteLine(n_superior);

for (int i = n_inferior; i < n_superior; i++)
{
    if (i % 2 == 0)
    {
        soma_par = soma_par + i;
    }
}
Console.WriteLine("A soma de todos os números pares entre " + n_inferior + " e " + n_superior + " é " + soma_par);
