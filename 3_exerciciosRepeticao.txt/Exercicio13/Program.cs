// Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.

int soma_par = 0;

Console.WriteLine("Segue o somatório dos valores pares existentes entre 1 e 500.");

for (int i = 1; i <= 500; i++)
{
    if (i % 2 == 0)
    {
        soma_par += i;
    }
}

Console.WriteLine(soma_par);
