/* Crie uma classe Carro com os atributos: modelo, marca, cor e placa. 
 * Crie um método para definir os atributos, outro método para ligar o carro
 * e outro método para desligar o carro.
 */

Carro c = new Carro();
c.modelo = "HATCH";
c.placa = "RD7U88";
c.cor = "BORDO";
c.marca = "CHEVROLET";

c.ligar();
Console.WriteLine("O carro está ligado!");
Console.WriteLine("Dados do carro:\r\nModelo: " + c.modelo + "\r\nPlaca: " + c.placa + "\r\nCor: " + c.cor + "\r\nMarca: " + c.marca);

c.desligar();
Console.WriteLine("O carro está desligado!");
public class Carro
{
    public string modelo;
    public string marca;
    public string cor;
    public string placa;

    public bool ligado;

    public void ligar()
    {
        Console.WriteLine("O carro está sendo ligado");
        ligado = true;
    }
        public void desligar()
    {
        Console.WriteLine("O carro está sendo desligado");
        ligado = false;
    }






}
