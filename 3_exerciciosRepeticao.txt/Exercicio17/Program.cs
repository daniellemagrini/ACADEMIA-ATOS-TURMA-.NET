﻿// Apresentar os quadrados dos números inteiros de 15 a 200.

Console.Clear();
Console.WriteLine("Apresentar os quadrados dos números inteiros de 15 a 200.");

int numero;

for (numero = 15; numero <= 200; numero++)
{
    Console.WriteLine("Quadrado de " + numero + " é: " + Math.Pow(numero, 2));
}