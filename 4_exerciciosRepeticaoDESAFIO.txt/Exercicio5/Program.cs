/* Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos
 * por 11 dão resto 5.
 */

int qtde_n;

Console.WriteLine("Quantos números deseja gerar?");
qtde_n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtde_n; i++)
{
    Random numeros = new Random();
    int n = Convert.ToInt32(numeros.Next(1000,1999));
    
    if (n % 11 == 5)
    {
        Console.WriteLine("O número " + n + " dividido por 11, sobra 5.");
    }
    else
    {
        Console.WriteLine("O número " + n + " dividido por 11, não sobra 5.");
    }
}


