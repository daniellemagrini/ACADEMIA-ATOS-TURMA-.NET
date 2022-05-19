/* Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
 * da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
 * e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
 * Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
 */

float area;
float qtde_lata;
double qtde_lata_int;
float preco_lata = 80;
float preco;
string preco_total;

Console.WriteLine("Qual o tamanho (m²) da area a ser pintada?");
area = float.Parse(Console.ReadLine());

qtde_lata = area / 3;
preco = preco_lata * qtde_lata;

qtde_lata_int = Math.Ceiling(qtde_lata); // Math Ceiling arredonda sempre pra cima os números quebrados.
preco_total = preco.ToString("C"); // Colocou em string o preco para transformar em formato moeda.

Console.WriteLine("Será necessário " + qtde_lata_int + " latas de tinta. Isso corresponde a " + preco_total + " reais.");
