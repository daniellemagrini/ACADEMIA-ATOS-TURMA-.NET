/*Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
 * se a média das duas notas for maior ou igual a 7,0. 
 * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
 * é a média entre a nota do exame e a média das 2 notas. 
 * Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”,
 * caso contrário deve escrever “Reprovado”.
*/

float nota1;
float nota2;
float nota_exame;

Console.WriteLine("Digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

if (media >= 7)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("Digite a nota do exame");
    nota_exame = float.Parse(Console.ReadLine());
    float media2 = (nota1 + nota2 + nota_exame) / 3;

    if (media2 >= 5)
    {
        Console.WriteLine("APROVADO NO EXAME");
    }
    else
    {
        Console.WriteLine("REPREVADO");
    }
}
