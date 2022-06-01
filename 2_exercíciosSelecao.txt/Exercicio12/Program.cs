/* Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
 * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
 * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
 * armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente 
 * de trabalho vale R$ 20,00. No final do processamento, exibir o salário total e
 * o salário excedente do operário.
*/

int codigo;
float num_horas;
float salario = 0;
float extra;
float salario_extra;

Console.WriteLine("Qual o código do colaborador?");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Digite as horas trabalhar desse colaborador");
num_horas = float.Parse(Console.ReadLine());


if (num_horas > 50)
{
    extra = num_horas - 50;
    salario = (num_horas - extra) * 10;
    salario_extra = extra * 20;
    Console.WriteLine("Salário fixo:" + salario);
    Console.WriteLine("Salário extra:" + salario_extra);
}
else
{
    Console.WriteLine("O colaborador não teve adicional no salário.");
    salario = num_horas * 10;
    Console.WriteLine("Salário:" + salario);
    
}

