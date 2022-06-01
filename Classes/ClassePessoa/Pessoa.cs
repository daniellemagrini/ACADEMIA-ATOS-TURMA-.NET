using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePessoa
{
    public class Pessoa
    {
        //MÉTODOS

        public string nome;
        private int idade;
        private double altura;
        private double peso;
        private string cor_do_cabelo;
        private string cor_dos_olhos;

        // CONSTRUTOR

        public Pessoa(string nome, int idade, double altura, double peso, string cor_do_cabelo, string cor_dos_olhos)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            this.cor_do_cabelo = cor_do_cabelo;
            this.cor_dos_olhos = cor_dos_olhos;
        }

        //MÉTODOS

        public void apresenta_info_pessoa()
        {
            Console.WriteLine("Segue descrição dessa pessoa:\r\n");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine(cor_do_cabelo);
            Console.WriteLine(cor_dos_olhos);
        }

        





    }
}
