using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Livro
    {
        //ATRIBUTOS

        public string titulo;
        public string autor;
        public int pagina;
        public int ano;
        public int edicao;

        //CONSTRUTOR
        public Livro(string titulo, string autor, int pagina, int ano, int edicao)
        {
            //Sempre que for nome igual da variavel, tem que usar o this. para falar que é a variavel dessa classe. senao ele vai entender que é outra variavel.

            this.titulo = titulo;
            this.autor = autor;
            this.pagina = pagina;
            this.ano = ano;
            this.edicao = edicao;
        }

        // MÉTODOS
        public void apresenta_info_livro()
        {
            Console.WriteLine("O livro " + this.titulo + " do(a) autor(a) " + this.autor + ", tem " + this.pagina + " páginas, foi lançado no ano de " + this.ano + " e está na edição " + this.edicao + ".");
        }

    }
}
