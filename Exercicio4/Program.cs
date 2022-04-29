// See https://aka.ms/new-console-template for more information

/*
 * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA
 * e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos
 * em variáveis diferentes.
**/

Console.WriteLine("Exercício 4 - Aula 2");
Console.WriteLine("Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA\n" +
    "e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos\n" +
    "em variáveis diferentes.");

Console.WriteLine("Qual sua data de nascimento?");
Console.WriteLine("Digite o dia em que nasceu");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o numero do mês em que nasceu");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("E por fim, digite o ano completo em que nasceu");
int ano = int.Parse(Console.ReadLine());

DateOnly data_nasc = new DateOnly(ano, mes, dia); //Transforma o que foi digitado em data
string data_nasc1 = data_nasc.ToString("yyyy/MM/dd");
string data_nasc2 = data_nasc.ToString("yy/MM/dd");

Console.WriteLine("Sua data de nascimento no formato AAAAMMDD é:" + data_nasc1);
Console.WriteLine("Sua data de nascimento no formato AAMMDD é:" + data_nasc2);
