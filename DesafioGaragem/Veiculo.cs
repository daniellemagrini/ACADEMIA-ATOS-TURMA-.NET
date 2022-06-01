using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem
{
    class Veiculo //  Classe Base
    {
        // Variaveis que armazenam os dados do veículo (placa e data e hora da entrada)
        public string placa; // Placa do veículo
        public int vaga; // Número da vaga que o veículo está estacionado
        public int tipo; // 1 para carro e 2 para moto
        public string dataHoraEntrada; // data e hora de entrada conforme sistema
        public double valorHora;

        // Construtor (Toda classe que não é static, precisa ter um construtor)
        // A entrada para chamar esse construtor é a placa e a data/hora entrada, logo, precisa ter essas duas informações para chamar o construtor.
        // Construtor é sempre o mesmo nome da classe (assim ele é o construtor daquela classe) - identificação.  
        public Veiculo(int tipo, string placa, string dataHoraEntrada, double valorHora)
        {
            this.tipo = tipo;
            this.placa = placa.ToUpper();
            this.dataHoraEntrada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));

            if (tipo == 1) // Tipo Carro
            {
                this.valorHora = 2.50;
            }
            else if (tipo == 2) // Tipo Moto
            {
                this.valorHora = 1.50;
            }
        }
        public Veiculo(string placa)
        {
            this.placa = placa;            
        }
        public Veiculo(string placa, object dataHoraEntrada)
        {
            this.placa= placa;
            this.dataHoraEntrada = dataHoraEntrada.ToString();
        }
    }
}
