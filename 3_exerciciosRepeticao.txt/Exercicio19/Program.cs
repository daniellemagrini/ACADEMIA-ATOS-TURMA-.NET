/*  A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
 *  coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 *  a) média do salário da população;
 *  b) média do número de filhos;
 *  c) maior salário;
 *  d) percentual de pessoas com salário até R$ 100,00.
 *  O final da leitura de dados se dará com a entrada de um salário negativo.
 */

int qtde_filhos;
double salario;
int qtde_habitantes;
double media_salario;
double soma_salario = 0;
int soma_filhos = 0;
int media_filhos;
double maior_salario;
double salario_ate_100 = 0;

Console.WriteLine("Quantos habitantes participaram da pesquisa?");
qtde_habitantes = Convert.ToInt32(Console.ReadLine());

List<double> lista_salarios = new List<double>();
List<int> lista_filhos = new List<int>();

for (int i = 0; i < qtde_habitantes; i++)
{
    Console.WriteLine("Qual o salário? Caso queira encerrar, digite um salário negativo.");
    salario = Convert.ToDouble(Console.ReadLine());
    if (salario < 0)
    {
        Console.WriteLine("Programa encerrado!");
        break;
    }
    lista_salarios.Add(salario);
    soma_salario += salario;
    if (salario <= 100)
    {
        salario_ate_100++;
    }
    Console.WriteLine("Quantos filhos?");
    qtde_filhos = Convert.ToInt32(Console.ReadLine());
    lista_filhos.Add(qtde_filhos);
    soma_filhos += qtde_filhos;
}

lista_salarios.Sort();

maior_salario = lista_salarios[lista_salarios.Count - 1];
media_salario = soma_salario / lista_salarios.Count();
media_filhos = soma_filhos / lista_filhos.Count();
double percente_salario_ate_100 = (salario_ate_100 * 100) / qtde_habitantes;

Console.WriteLine("Maior Salário: " + maior_salario);
Console.WriteLine("Média dos Salários: " + media_salario);
Console.WriteLine("Média de filhos: " + media_filhos);
Console.WriteLine("Percentual de pessoas com salário até 100,00: " + percente_salario_ate_100);