// See https://aka.ms/new-console-template for more information

/*
 * 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
 * do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
 * Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
 * se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
 * Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
 * da entrada e das duas prestações, de acordo com as regras acima. 
 * Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
 * conseqüente pagamento dos boletos das duas prestações.
**/

Console.WriteLine("Exercício 9 - Aula 2");
Console.WriteLine("Uma loja vende seus produtos no sistema de entrada mais duas prestações,\n" +
    "sendo a entrada maior do que ou igual às duas prestações, que devem ser iguais, inteiras\n" +
    "e as maiores possíveis. Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as\n" +
    "duas prestações são iguais a R$ 90,00; se o valor da mercadoria for R$ 302,75\n" +
    "a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.\n" +
    "Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor\n" +
    "da entrada e das duas prestações, de acordo com as regras acima.Observe que uma justificativa\n" +
    "para a adoção desta regra é que ela facilita a confecção e o conseqüente pagamento dos boletos\n" +
    "das duas prestações.");

Console.WriteLine("Qual o valor da mercadoria?");
float preco = float.Parse(Console.ReadLine());

float resto = preco % 3; //resto da divisão
float preco2 = preco - resto;
float entrada = preco2 / 3 + resto;
float parcelas = preco2 / 3;

Console.WriteLine("Entrada: " + entrada);
Console.WriteLine("Parcela 1: " + parcelas);
Console.WriteLine("Parcela 2: " + parcelas);

