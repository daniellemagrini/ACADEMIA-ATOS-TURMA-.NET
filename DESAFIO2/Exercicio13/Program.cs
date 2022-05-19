/* Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
 * seu peso ideal, utilizando as seguintes fórmulas:
 * Para homens: (72.7 * h) - 58
 * Para mulheres: (62.1 * h) - 44.7
 */

double altura;
String genero;
double peso;
string genero_maiuscula;

Console.WriteLine("Qual o seu gênero? (H/M)");
genero = Console.ReadLine();
genero_maiuscula = genero.ToUpper();

while (genero_maiuscula != "H" && genero_maiuscula != "M")
{
    Console.WriteLine("Gênero inválido. Favor digitar H, caso seja homem ou M, caso seja mulher");
    Console.WriteLine("Qual o seu gênero? (H/M)");
    genero = Console.ReadLine();
    genero_maiuscula = genero.ToUpper();
}

Console.WriteLine("Qual a sua altura?");
altura = double.Parse(Console.ReadLine());

if (genero_maiuscula == "M")
{
    peso = (62.1 * altura) - 44.7;
    Console.WriteLine("Seu peso ideal é: " + peso);
}
else if (genero_maiuscula == "H")
{
    peso = (72.7 * altura) - 58;
    Console.WriteLine("Seu peso ideal é: " + peso);
}
