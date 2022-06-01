/*Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
 * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
 * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
 * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
 * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
 * menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
 * 150, avisá-lo que será necessário adicionar 2 unidades de insulina.
 */

float glicemia;
int i = 0;
float glicemia_total = 0;
float media;

while (i < 3)
{
    Console.WriteLine("Digite o valor de glicemia em jejum");
    glicemia = float.Parse(Console.ReadLine());

    if (glicemia < 65)
    {
        Console.WriteLine("Risco de hipoglicemia");
    }
    else if (glicemia > 250)
    {
        Console.WriteLine("Risco de hiperglicemia");
    }
    else
    {
        Console.WriteLine("Sem riscos");
    }
    glicemia_total = glicemia_total + glicemia;
    i++;
}
Console.WriteLine(glicemia_total);
media = glicemia_total / 3;

if (media < 80)
{
    Console.WriteLine("Sua média foi menor que 80, é necessário diminuir 2 unidades de insulina");
}
else if(media > 150)
{
    Console.WriteLine("Sua média foi maior que 150, é necessário adicionar 2 unidades de insulina");
}
else
{
    Console.WriteLine("Sem necessidade de insulina");
}


