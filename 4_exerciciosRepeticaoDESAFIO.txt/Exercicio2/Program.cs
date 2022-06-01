/* Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
 * Polegada = Centímetro * 2,54.
 */

double polegada;

Console.WriteLine("Tabela de conversão de polegadas para centiimetros:\r\n");

for (int i = 1; i <= 20; i++)
{
    polegada = i * 2.54;
    Console.WriteLine(i + " centímetro(s) = " + polegada + " polegadas.");
}