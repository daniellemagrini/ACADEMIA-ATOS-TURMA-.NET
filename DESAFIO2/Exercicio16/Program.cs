/* Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.
 * Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
 * na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.
 * Caso contrário, mostre uma mensagem indicando que os dois times irão se
 * enfrentar novamente em um novo jogo.
 * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
 * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
 * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
*/

string time_da_casa;
string time_de_fora;
int gol_time_da_casa;
int gol_time_de_fora;

Console.WriteLine("Digite o nome do time da casa.");
time_da_casa = Console.ReadLine();
Console.WriteLine("Digite o nome do time de fora.");
time_de_fora = Console.ReadLine();
Console.WriteLine("Qual o placar do time da casa?");
gol_time_da_casa = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o placar do time de fora?");
gol_time_de_fora = int.Parse(Console.ReadLine());

if (gol_time_de_fora >= gol_time_da_casa + 2)
{
    Console.WriteLine(time_de_fora + " classificado para a próxima fase!");
}
else
{
    Console.WriteLine(time_da_casa + " e " + time_de_fora + " terão que se enfrentar novamente!");

}


