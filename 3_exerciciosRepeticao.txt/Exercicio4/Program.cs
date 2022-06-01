/* Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
 * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
 * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA.
 * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário
 * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos
 * e o número de votos em branco. 
 */

int computa_voto;
int voto;
int votos_joao = 0;
int votos_zeca = 0;
int votos_branco = 0;
int votos_nulo = 0;

Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
computa_voto = int.Parse(Console.ReadLine());

while (computa_voto == 1)
{
    Console.WriteLine("Digite o voto correspondente:\r\n");
    Console.WriteLine("1 - JOÃO\r\n2 - ZECA\r\n3 - BRANCO\r\n");
    voto = int.Parse(Console.ReadLine());

    if (voto == 1)
    {
        votos_joao++;
        Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
        computa_voto = int.Parse(Console.ReadLine());
    }
    else if (voto == 2)
    {
        votos_zeca++;
        Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
        computa_voto = int.Parse(Console.ReadLine());
    }
    else if (voto == 3)
    {
        votos_branco++;
        Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
        computa_voto = int.Parse(Console.ReadLine());
    }
    else
    {
        votos_nulo++;
        Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
        computa_voto = int.Parse(Console.ReadLine());
    }
    
}
if (computa_voto == 2)
{
    if (votos_joao > votos_zeca)
    {
        Console.WriteLine("João foi eleito com " + votos_joao + " de votos.\r\n");
    }
    else if (votos_zeca > votos_joao)
    {
        Console.WriteLine("Zeca foi eleito com " + votos_zeca + " de votos.\r\n");
    }
    else if (votos_joao == votos_zeca)
    {
        Console.WriteLine("João e Zeca empataram com " + votos_zeca + " de votos.\r\n");
    }

    Console.WriteLine("Votos para João: " + votos_joao + "\r\nVotos para Zeca: " + votos_zeca + "\r\nVotos em Branco: " + votos_branco + "\r\nVotos nulos: " + votos_nulo);
}
if (computa_voto != 1 && computa_voto!= 2)
{
    Console.WriteLine("Escolha inválida.\r\n");
    Console.WriteLine("Quer computar um voto?\r\n1 - Sim\r\n2 - Não");
    computa_voto = int.Parse(Console.ReadLine());
}





