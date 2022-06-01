// Apresentar o total da soma dos cem primeiros números inteiros.


int soma = 0;

Console.WriteLine("Segue a soma dos cem primeiros números inteiros:");

for (int i = 1; i <= 100; i++)
{
    soma += i;
}

Console.WriteLine(soma);