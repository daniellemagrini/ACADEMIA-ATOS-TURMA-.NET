using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem
{
    class menu
    {
        // Gravar no arquivo
        public static void gravarArquivo(Veiculo objeto)
        {
            string dataHoraEntrada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));

            try
            {
                StreamWriter sw = new StreamWriter("BD.dat", true);
                sw.WriteLine("TIPO: " + objeto.tipo + "; PLACA: " + objeto.placa + "; ENTRADA: " + objeto.dataHoraEntrada + "; VALOR DA HORA: " + objeto.valorHora);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo com problemas");
            }
        }

        //Carregar os dados do arquivo
        public static List<Veiculo> carregarListas()
        {
            StreamReader sr;
            string nomeArquivo = "BD.dat";
            string placa = String.Empty ;
            string dataHoraEntrada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));

            List<Veiculo> lista = new List<Veiculo>();

            try
            {
                sr = new StreamReader(nomeArquivo);
                do
                {
                    placa = sr.ReadLine();
                    lista.Add(new Veiculo(placa, dataHoraEntrada));
                }
                while (!sr.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo com problemas ou inexistente");
            }
            return lista;
        }

        //Cadastrar Veículo
        public static void cadastrarVeiculo(List<Veiculo> lista)
        {

            string placa = String.Empty;
            int tipo;
            string dataHoraEntrada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));
            double valorHora = 2.50;

            do
            {
                Console.WriteLine("Qual o tipo do veículo?");
                Console.WriteLine("1 - CARRO\r\n2 - MOTO\r\n3 - VOLTAR AO MENU PRINCIPAL\r\n4 - SAIR");
                tipo = Convert.ToInt32(Console.ReadLine());

                while (tipo != 1 && tipo != 2 && tipo != 3 && tipo != 4)
                {
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    Console.WriteLine("1 - CARRO\r\n2 - MOTO\r\n3 - VOLTAR AO MENU PRINCIPAL\r\n4 - SAIR");
                    tipo = Convert.ToInt32(Console.ReadLine());
                }

                if (tipo == 1)
                {
                    Console.WriteLine("Qual a placa do carro?");
                    placa = Console.ReadLine();
                    Veiculo objeto = new Veiculo(tipo, placa.ToUpper(), dataHoraEntrada, valorHora);
                    lista.Add(objeto);
                    menu.gravarArquivo(objeto);
                }
                else if (tipo == 2)
                {
                    Console.WriteLine("Qual a placa da moto?");
                    placa = Console.ReadLine();
                    Veiculo objeto = new Veiculo(tipo, placa.ToUpper(), dataHoraEntrada, valorHora);
                    lista.Add(objeto);
                    menu.gravarArquivo(objeto);
                }
                else if (tipo == 3)
                {
                    Console.Clear();
                    return;
                }
                else if (tipo == 4)
                {
                    Console.Clear();
                    Console.WriteLine("ATÉ LOGO!");
                    Environment.Exit(0);
                    break;
                }
            } while (tipo != 4);
        }
        public static void veiculosNaGaragem(List<Veiculo> lista)
        {
            string dataHoraEntrada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine("Veículos estacionados em {0}\r\n", DateTime.Now + ":");

            if (new FileInfo("BD.dat").Length == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
            else
            {
                using var arquivo = new StreamReader("BD.dat");
                string? linha;

                while ((linha = arquivo.ReadLine()) != null)
                    Console.WriteLine(linha);
            }
        }

        //Saída do veículo
        public static void saidaVeiculo(List<Veiculo> lista)
        {
            string placa = string.Empty;

            Console.WriteLine("Qual a placa do veículo?");
            placa = Console.ReadLine().ToUpper();
            Veiculo objeto = new Veiculo(placa);

            using var arquivo = new StreamReader("BD.dat");
            string? linha;

            while (((linha = arquivo.ReadLine()) != null))    
            {
                if (linha.Contains(placa))
                {
                    //linhas para remover a placa do arquivo.*****
                    Console.WriteLine("Veículo removido");
                    break;
                }
                else
                {
                    Console.WriteLine("Veículo não se encontra estacionado. Impossível dar saída do mesmo.");
                    return;
                }
            }
        }

        /*public static DateTime calcularValor()
        {
            DateTime dataHoraSaida = DateTime.Now;
            double valor;

            TimeSpan tempo = dataHoraSaida - dataHoraEntrada; // Como pegar a data hora da entrada?
            valor = valorHora * tempo;
        }*/
    }
}

