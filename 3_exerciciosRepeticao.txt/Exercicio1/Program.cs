/* Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
 * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
 * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número
 * fornecido pelo usuário.
 * Exemplo:
 * Digite um número inteiro positivo: -8
 * Valor incorreto!
 * Digite um número inteiro positivo: 8
 * Numero digitado: 8
 * Números inteiros pares entre 1 e 8: 2, 4, 6.
 */

int num_aux = 0;
int num = 0;
int i = 0;
string resposta;
string resposta_aux;

while (num <= 0)
{
    Console.WriteLine("Favor digitar um número inteiro positivo");
    num = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < num; i++)
{
    while (num_aux < num)
    {
        num_aux = num_aux + 2;
        Console.WriteLine(num_aux);
    }
    break;
}

Console.WriteLine("Deseja digitar um novo número? (S/N)");
resposta_aux = Console.ReadLine();

resposta = resposta_aux.ToUpper();

while (resposta != "S" && resposta != "N")
{
    Console.WriteLine("Favor digitar apenas S para sim ou N para não");
    Console.WriteLine("Deseja digitar um novo número? (S/N)");
    resposta_aux = Console.ReadLine();

    resposta = resposta_aux.ToUpper();
}

if (resposta == "N")
{
    Console.WriteLine("Programa encerrado!");
}
else if (resposta == "S")
{
    while (resposta == "S")
    {
        num = 0;
        i = 0;
        num_aux = 0;

        while (num <= 0)
        {
            Console.WriteLine("Favor digitar um número inteiro positivo");
            num = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < num; i++)
        {
            while (num_aux < num)
            {
                num_aux = num_aux + 2;
                Console.WriteLine(num_aux);
            }
            break;
        }

        Console.WriteLine("Deseja digitar um novo número? (S/N)");
        resposta_aux = Console.ReadLine();

        resposta = resposta_aux.ToUpper();
        if (resposta == "N")
        {
            Console.WriteLine("Programa encerrado!");
        }
    }
}




