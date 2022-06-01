
using ClasseLivro;

string titulo;
string autor;
int pagina;
int ano;
int edicao;

Console.WriteLine("Digite o título do livro");
titulo = Console.ReadLine();
Console.WriteLine("Digite o autor do livro");
autor = Console.ReadLine();
Console.WriteLine("Digite a quantidade de páginas do livro");
pagina = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de publicação do livro");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a edição do livro");
edicao = int.Parse(Console.ReadLine());

Livro l1 = new Livro(titulo, autor, pagina, ano, edicao); // As variaveis não precisam ter nomes iguais. aqui ela só está passando a variavel que ela leu aqui para ser equivalente ao que está na classe livro (aqui poderia ser t,a,x,etc)
l1.apresenta_info_livro();
