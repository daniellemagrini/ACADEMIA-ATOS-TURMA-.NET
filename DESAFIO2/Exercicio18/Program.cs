// Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

float num1;
float num2;
float num3;

Console.WriteLine("Digite um número");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número");
num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite mais um número");
num3 = float.Parse(Console.ReadLine());


if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("O maior valor entre os digitados é: " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("O maior valor entre os digitados é: " + num2);
}
else if (num3 >= num1 && num3 >= num2)
{
    Console.WriteLine("O maior valor entre os digitados é: " + num3);
}
else if (num1 == num2 && num1 == num3)
{
    Console.WriteLine("Os valores são todos iguais.");
}

List<float> lista_numeros = new List<float>();
lista_numeros.Add(num1);
lista_numeros.Add(num2);
lista_numeros.Add(num3);
lista_numeros.Sort();

foreach (float num in lista_numeros)
    Console.WriteLine(num);