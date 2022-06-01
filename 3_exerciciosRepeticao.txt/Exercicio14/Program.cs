// Mostrar as potências de 2 variando de 0 a 10.

Console.WriteLine("Segue potências de 2 variando de 0 a 10.");

for (int i = 1; i < 10; i++)
{
    int potencia = 2 ^ i;
    Console.WriteLine("2 elevado a " + i + " = " + potencia);
}

