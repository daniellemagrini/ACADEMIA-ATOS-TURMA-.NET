/* Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
 * A cada solicitação, teste se o usuário informou um valor válido. 
 * Por exemplo: se o nome for não for lido corretamente
 * (ou seja, se estiver em branco ou se for um número), informe que ele está incorreto e saia do programa em VS.
 * Se o nome for lido corretamente, solicite a idade. 
 * Se ela for incorreta (menor ou igual a zero), informe que está errada e saia. 
 * Se estiver correta, solicite o salário. 
 * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
 * Se estiver correto, mostre todos os valores lidos.
 */

string nome;
int idade;
double salario;
string aux = "0123456789,.;*/=+-_)(%$#[]´´~@  !&";

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();

if (aux.Contains(nome))
    { 
    Console.WriteLine("Nome inválido!\r\nPrograma encerrado!");
    return;
}
else
{
    Console.WriteLine("Qual a sua idade?");
    idade = Convert.ToInt32(Console.ReadLine());
    
    if (idade <= 0)
    {
        Console.WriteLine("Idade Inválida!\r\nPrograma encerrado!");
        return;
    }
    else
    {
        Console.WriteLine("Qual seu salário?");
        salario = Convert.ToDouble(Console.ReadLine());

        if (salario <= 0)
        {
            Console.WriteLine("Salário Inválido!\r\nPrograma encerrado!");
            return;
        }
        else
        {
            Console.WriteLine("Dados informados:\r\nNome: " + nome + "\r\nIdade: " + idade + "\r\nSalário: " + salario);
        }
    }
}
