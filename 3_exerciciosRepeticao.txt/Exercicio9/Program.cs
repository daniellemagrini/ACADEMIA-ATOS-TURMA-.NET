/* Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
 * o zoológico num determinado dia, imprimindo:
 * Quantas pessoas tem entre 1 e 3 filhos.
 * Quantas pessoas tem entre 4 e 7 filhos.
 * Quantas pessoas tem mais de 8 filhos.
 * Quantas pessoas não tem filhos.
 */

int qtde_filhos;
int i = 0;
int qtde_visitantes;
int ate_3_fihos = 0;
int ate_7_fihos = 0;
int mais_8_filhos = 0;
int nenhum_filho = 0;
string opcao;

inicio:

Console.Clear();

Console.WriteLine("Quantas pessoas visitaram o zoológico nesta data?");
qtde_visitantes = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < qtde_visitantes; i++)
{
    Console.WriteLine("Quantos filhos você tem ?");
    qtde_filhos = Convert.ToInt32(Console.ReadLine());
    
    if (qtde_filhos == 0)
    {
        nenhum_filho++;
    }
    else if (qtde_filhos > 0 && qtde_filhos <= 3)
    {
        ate_3_fihos++;
    }
    else if (qtde_filhos > 3 && qtde_filhos <= 7)
    {
        ate_7_fihos++;
    }
    else if (qtde_filhos >= 8)
    {
        mais_8_filhos++;
    }
    else
    {
        Console.WriteLine("Quantidade inválida.");
    }
}

Console.WriteLine("Pessoas entre 1 e 3 filhos: " + ate_3_fihos + "\r\nPessoas entre 4 e 7 filhos: " + ate_7_fihos + "\r\nPessoas com mais de 8 filhos: " + mais_8_filhos + "\r\nPessoas com nenhum filho: " + nenhum_filho);

Console.WriteLine("Deseja voltar ao início? S/N");
opcao = Console.ReadLine().ToUpper();

if (opcao == "S")
{
    goto inicio;
}
else
{
    Console.WriteLine("Tenha um bom dia! \r\nObrigada!");
}