/* Ler nome, sexo e idade de 50 pessoas e após imprimir:
 * Número de pessoas do sexo masculino.
 * Número de pessoas do sexo feminino.
 * Número de pessoas com idade inferior a 30 anos.
 * Número de pessoas com idade superior a 60 anos.
 * Média de idade das mulheres.
 */

string nome;
string sexo;
string sexo_aux;
int sexo_feminino = 0;
int sexo_masculino = 0;
int idade;
int idade_feminino_inferior_30 = 0;
int idade_masculino_inferior_30 = 0;
int idade_feminino_superior_60 = 0;
int idade_masculino_superior_60 = 0;
int idade_feminino_intermediaria = 0;
int idade_masculino_intermediaria = 0;
int idade_inferior_30 = 0;
int idade_superior_60 = 0;
int idade_feminino;
int idade_masculino;
int media_idade_feminino;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Qual o seu nome?");
    nome = Console.ReadLine();
    Console.WriteLine("Qual seu sexo? (F para feminino e M para Masculino)");
    sexo_aux = Console.ReadLine();
    sexo = sexo_aux.ToUpper();

    while (sexo != "F" && sexo != "M")
    {
        Console.WriteLine("Sexo inválido. favor digitar apenas F para feminino ou M para masculino");
        sexo_aux = Console.ReadLine();
        sexo = sexo_aux.ToUpper();
    }

    if (sexo == "F")
    {
        sexo_feminino++;

        Console.WriteLine("Qual a sua idade?");
        idade_feminino = Convert.ToInt32(Console.ReadLine());

        while (idade_feminino <= 0)
        {
            Console.WriteLine("Idade inválida. favor digitar um número inteiro e maior que zero.");
            idade_feminino = Convert.ToInt32(Console.ReadLine());
        }

        if (idade_feminino < 30)
        {
            idade_feminino_inferior_30++;
        }
        else if (idade_feminino > 60)
        {
            idade_feminino_superior_60++;
        }
        else
        {
            idade_feminino_intermediaria++;
        }
    }
    else if (sexo == "M")
    {
        sexo_masculino++;

        Console.WriteLine("Qual a sua idade?");
        idade_masculino = Convert.ToInt32(Console.ReadLine());

        while (idade_masculino <= 0)
        {
            Console.WriteLine("Idade inválida. favor digitar um número inteiro e maior que zero.");
            idade_masculino = Convert.ToInt32(Console.ReadLine());
        }

        if (idade_masculino < 30)
        {
            idade_masculino_inferior_30++;
        }
        else if (idade_masculino > 60)
        {
            idade_masculino_superior_60++;
        }
        else
        {
            idade_masculino_intermediaria++;
        }
    }
}

idade_inferior_30 = idade_feminino_inferior_30 + idade_masculino_inferior_30;
idade_superior_60 = idade_feminino_superior_60 + idade_masculino_superior_60;
media_idade_feminino = (idade_feminino_inferior_30 + idade_feminino_superior_60 + idade_feminino_intermediaria) / sexo_feminino;

Console.WriteLine("Número de pessoas do sexo masculino: " + sexo_masculino + "\r\nNúmero de pessoas do sexo feminino: " + sexo_feminino + "\r\nNúmero de pessoas com idade inferior a 30 anos: " + idade_inferior_30 + "\r\nNúmero de pessoas com idade superior a 60 anos: " + idade_superior_60);
Console.WriteLine("Média de idade das mulheres: " + media_idade_feminino);