/* Faça um programa no VS que receba uma hora, dividida em 2 variáveis 
 * (uma para hora e outra para minutos). O programa deve exibir se a
 * hora digitada está ou não válida. Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
*/

int hora;
int minuto;

Console.WriteLine("Favor digitar a hora");
hora = int.Parse(Console.ReadLine());

while (hora < 00 || hora > 23)
{
    Console.WriteLine("Hora inválida! Digite novamente.");
    Console.WriteLine("Favor digitar a hora");
    hora = int.Parse(Console.ReadLine());
}

Console.WriteLine("Favor digitar os minutos");
minuto = int.Parse(Console.ReadLine());


while (minuto < 0 || minuto > 59)
{
    Console.WriteLine("Minutos inválidos! Digite novamente.");
    Console.WriteLine("Favor digitar os minutos");
    minuto = int.Parse(Console.ReadLine());
}

Console.WriteLine("Hora digitada: " + hora + ":" + minuto);

