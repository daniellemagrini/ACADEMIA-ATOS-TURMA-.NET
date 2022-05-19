/* Escreva um algoritmo para o jogo de adivinhação do número secreto. 
 * O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
 * plus: você pode gerar o número de forma randomica (função random c#).
 */

int num1;
int num2;
int num3;

Random aux = new Random();
int num = aux.Next(0, 10);

Console.WriteLine("Adivinhe o número. Você tem 3 chances");
Console.WriteLine("Qual seu primeiro palpite? Ele está entre 0 e 10");
num1 = int.Parse(Console.ReadLine());

if (num1 == num)
{
    Console.WriteLine("Você acertou!");
}
else
{
    if (num1 > num)
    {
        Console.WriteLine("Tente novamente. O número é menor.");
        Console.WriteLine("Qual seu segundo palpite?");
        num2 = int.Parse(Console.ReadLine());

        if (num2 == num)
        {
            Console.WriteLine("Você acertou!");
        }
        else
        {
            if (num2 > num)
            {
                Console.WriteLine("Tente novamente. O número é menor.");
                Console.WriteLine("Qual seu terceiro e último palpite?");
                num3 = int.Parse(Console.ReadLine());
                
                if (num3 == num)
                {
                    Console.WriteLine("Você acertou!");
                }
                else if (num3 != num)
                {
                    Console.WriteLine("Você errou! O número era: " + num);
                }
            }
            else if (num2 < num)
            {
                Console.WriteLine("Tente novamente. O número é maior.");
                Console.WriteLine("Qual seu terceiro e último palpite?");
                num3 = int.Parse(Console.ReadLine());

                if (num3 == num)
                {
                    Console.WriteLine("Você acertou!");
                }
                else if (num3 != num)
                {
                    Console.WriteLine("Você errou! O número era: " + num);
                }
            }
        }
    }
    else if (num1 < num)
    {
        Console.WriteLine("Tente novamente. O número é maior.");
        Console.WriteLine("Qual seu segundo palpite?");
        num2 = int.Parse(Console.ReadLine());

        if (num2 == num)
        {
            Console.WriteLine("Você acertou!");
        }
        else
        {
            if (num2 > num)
            {
                Console.WriteLine("Tente novamente. O número é menor.");
                Console.WriteLine("Qual seu terceiro e último palpite?");
                num3 = int.Parse(Console.ReadLine());

                if (num3 == num)
                {
                    Console.WriteLine("Você acertou!");
                }
                else if (num3 != num)
                {
                    Console.WriteLine("Você errou! O número era: " + num);
                }
            }
            else if (num2 < num)
            {
                Console.WriteLine("Tente novamente. O número é maior.");
                Console.WriteLine("Qual seu terceiro e último palpite?");
                num3 = int.Parse(Console.ReadLine());

                if (num3 == num)
                {
                    Console.WriteLine("Você acertou!");
                }
                else if (num3 != num)
                {
                    Console.WriteLine("Você errou! O número era: " + num);
                }
            }
        }
    }
}
