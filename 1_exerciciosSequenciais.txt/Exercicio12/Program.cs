// See https://aka.ms/new-console-template for more information

/*
 * 12)  Um motorista de taxi deseja calcular o rendimento de seu carro na praça.
 * Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
 * marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia,
 * o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros.
 * Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

 * Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

 * Média do consumo = Total quilometragem/ quantidade de combustível gasto

 * Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

**/

Console.WriteLine("Exercício 12 - Aula 2");
Console.WriteLine(" Um motorista de taxi deseja calcular o rendimento de seu carro na praça.\n" +
    "Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a marcação\n" +
    "do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número\n" +
    "de litros de combustível gasto e o valor total (R$) recebido dos passageiros.\n" +
    "Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.");

double preco_combustivel = 6.90;

Console.WriteLine("Digite a quilometragem do odômetro no início do dia");
double km_inicio = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quilometragem do odômetro no fim do dia");
double km_fim = double.Parse(Console.ReadLine());
Console.WriteLine("Digite quantos litros foram usados no dia");
double qtde_combustivel = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor recebido no dia");
double valor_recebido = double.Parse(Console.ReadLine());

double total_km = km_fim - km_inicio;
double media_consumo = total_km / qtde_combustivel;
double lucro_dia = valor_recebido - (qtde_combustivel * preco_combustivel);

Console.WriteLine("RESUMO DO DIA");
Console.WriteLine("Total de km do dia: " + total_km);
Console.WriteLine("Média de consumo do dia: " + media_consumo);
Console.WriteLine("Lucro do dia: " + lucro_dia);
