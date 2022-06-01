/* Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c),
 * e então diga se esses lados podem ou não formar um triangulo. Para que os lados
 * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
 * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais),
 * isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
 */

float lado_a;
float lado_b;
float lado_c;

Console.WriteLine("Informe o tamanho dos lados da figura.");
Console.WriteLine("Tamanho do primeiro lado");
lado_a = float.Parse(Console.ReadLine());
Console.WriteLine("Tamanho do segundo lado");
lado_b = float.Parse(Console.ReadLine());
Console.WriteLine("Tamanho do terceiro lado");
lado_c = float.Parse(Console.ReadLine());

if (lado_a <= lado_b + lado_c && lado_b <= lado_a + lado_c && lado_c <= lado_a + lado_b){
    if (lado_a == lado_b && lado_a == lado_c)
    {
        Console.WriteLine("A figura é um Triangulo Equilátero.");
    }
    else if (lado_a != lado_b && lado_a != lado_c && lado_b != lado_c)
    {
        Console.WriteLine("A figura é um Triangulo Escaleno.");
    }
    else
    {
        Console.WriteLine("A figura é um Triangulo Isoceles.");
    }  
}
else
{
    Console.WriteLine("A figura não é um Triangulo.");
}