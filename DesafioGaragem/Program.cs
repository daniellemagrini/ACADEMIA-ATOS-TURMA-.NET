/* Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização),
 * uso adequado de Listas e Arquivos. Além disso, aplicar a ideia de menu de opções.
 * 
 * Construir um programa em VS que gerencie veículos em garagem. 
 * O programa deve ter um menu de operação. Os dados dos veículos devem ser persistidos em
 * arquivo e manipulados em uma lista dinâmica em memória. 
 * Os dados dos veículos são : string placa; DateTime dataHoraEntrada.
 * 
 * MENU
 * 1 - Cadastrar veículo entrando na garagem
 * 2 - Exibir veículos cadastrados
 * 3 - Sair
 * 
 * Opção: 
 * Observações: Criar a classe Veiculo (placa, dataHoraEntrada);
 * usar as classes List, StreamReader, StreamWriter, DateTime
 * Use como base de dados o arquivo 'garagem.dat'.
 */

using DesafioGaragem;
using System.Globalization;

/*int[] vaga_moto = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

int[] array = new int[50];

for (int i = 21; i <= 100; i++)
{
    array[i] = i + 1;
}
*/

int tipo;
string placa;
string opcao;

List<Veiculo> lista_veiculos = new List<Veiculo>();
lista_veiculos.AddRange(menu.carregarListas());


//MENU

do
{

    Console.WriteLine("\r\nMENU - Digite a sua opção (1/2/3)");
    Console.WriteLine("\r\n" +
        "1 - Cadastrar veículo entrando na garagem\r\n" +
        "2 - Exibir veículos cadastrados\r\n" +
        "3 - Dar saída em um veículo\r\n" +
        "4 - Sair\r\n");
    
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //Cadastrar veículo entrando na garagem
            menu.cadastrarVeiculo(lista_veiculos);
            break;

        case "2":
            //Exibir Veículos na garagem
            menu.veiculosNaGaragem(lista_veiculos);
            break;

        case "3":
            //Dar saída de veículo
            menu.saidaVeiculo(lista_veiculos);
            break;

        case "4":
            //SAIR
            Console.Clear();
            Console.WriteLine("ATÉ LOGO!");
            Environment.Exit(0);
            break;
            

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
while (opcao != "4");
