/* Foi realizada uma pesquisa de algumas características físicas da população de uma 
 * certa região, a qual coletou os seguintes dados referentes a cada habitante para 
 * serem analisados:
 * - sexo (masculino e feminino)
 * - cor dos olhos (azuis, verdes ou castanhos)
 * - cor dos cabelos ( louros, castanhos, pretos)
 * - idade 
 * Faça um algoritmo que determine e escreva: 
 * - a maior idade dos habitantes
 * - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
 * e que tenham olhos verdes e cabelos louros.
 * O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
 */

string sexo;
string cor_olhos;
string cor_cabelo;
int idade;
int pessoa = 0;

Random habitantes = new Random();
int n_habitantes = habitantes.Next(0,10);
Console.WriteLine("Foram testados " + n_habitantes + " habitantes nesta pesquisa.");

List<int> lista_idade = new List<int>();

for (int i = 0; i < n_habitantes; i++)
{
    Console.WriteLine("Qual seu sexo? (F/M)");
    string  sexo_aux = Console.ReadLine();
    sexo = sexo_aux.ToUpper();

    while (sexo != "F" && sexo != "M")
    {
        Console.WriteLine("Sexo inválido. favor digitar apenas F para feminino ou M para masculino.");
        Console.WriteLine("Qual seu sexo? (F/M)");
        sexo_aux = Console.ReadLine();
        sexo = sexo_aux.ToUpper();
    }

    Console.WriteLine("Qual a cor dos seus olhos?");
    Console.WriteLine("1 - Azuis\r\n2 - Verdes\r\n3 - Castanhos");
    cor_olhos = Console.ReadLine();

    while (cor_olhos != "1"  && cor_olhos != "2" && cor_olhos != "3")
    {
        Console.WriteLine("Opção inválida. Favor tentar novamente");
        Console.WriteLine("Qual a cor dos seus olhos?");
        Console.WriteLine("1 - Azuis\r\n2 - Verdes\r\n3 - Castanhos");
        cor_olhos = Console.ReadLine();
    }

    Console.WriteLine("Qual a cor dos seus cabelos?");
    Console.WriteLine("1 - Louros\r\n2 - Castanhos\r\n3 - Pretos");
    cor_cabelo = Console.ReadLine();

    while (cor_cabelo != "1" && cor_cabelo != "2" && cor_cabelo != "3")
    {
        Console.WriteLine("Opção inválida. Favor tentar novamente");
        Console.WriteLine("Qual a cor dos seus cabelos?");
        Console.WriteLine("1 - Louros\r\n2 - Castanhos\r\n3 - Pretos");
        cor_cabelo = Console.ReadLine();
    }

    Console.WriteLine("Qual sua idade? Caso queria encerrar o programa, digite -1");
    idade = Convert.ToInt32(Console.ReadLine());

    while (idade < -1)
    {
        Console.WriteLine("Idade inválida. Favor tentar novamente");
        Console.WriteLine("Qual sua idade? Caso queria encerrar o programa, digite -1");
        idade = Convert.ToInt32(Console.ReadLine());
    }
    if (idade == -1)
    {
        Console.WriteLine("Programa encerrado!");
    }
    lista_idade.Add(idade);
    if (sexo == "F" && idade >= 18 && idade <= 35 && cor_olhos == "2" && cor_cabelo == "1")
    {
        pessoa++;
    }
}

lista_idade.Sort();
int x = lista_idade.Count();
int maior_idade = lista_idade[lista_idade.Count-1];
Console.WriteLine("O habitante mais velho tem " + maior_idade);
Console.WriteLine("Tem " + pessoa + " habitante(s) com as características que busca.");




