/*Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
 *Área do triangulo = (base * altura) / 2;
 *Teste se a base ou a altura digitada não foi igual a zero. 
*/

float base_triangulo;
float altura_triangulo;
float area_triangulo;

Console.WriteLine("Digite o valor da base do triângulo");
base_triangulo = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da altura do triângulo");
altura_triangulo = float.Parse(Console.ReadLine());

if (base_triangulo == 0 || altura_triangulo == 0)
{
    Console.WriteLine("Valor zero, não permitido!");
}

else
{
    area_triangulo = (base_triangulo * altura_triangulo) / 2;
    Console.WriteLine("A área do triangulo é: " + area_triangulo);
} 

