


Lampada l = new Lampada();
l.potencia = 100;
l.ligar();
Console.WriteLine("Ligada? " + l.ligado + "\r\nPotencia? " + l.potencia);
l.desligar();
Console.WriteLine("Ligada? " + l.ligado + "\r\nPotencia? " + l.potencia);
double n;
n = l.retornaPotencia();
Console.WriteLine("A potencia da lampada cadastrada é de " + n);
Console.WriteLine("Retorno da funcao estarLigado " + l.estaLigada());
l.ligar();
Console.WriteLine("Retorno da funcao estarLigado " + l.estaLigada());



public class Lampada
{
    public bool ligado;
    public double potencia;
    public void ligar()
    {
        Console.WriteLine("A lampada está sendo ligada.");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("A lampada está sendo desligada.");
        ligado = false;
    }

    public double retornaPotencia()
    {
        return potencia;
    }
    public bool estaLigada()
    {
        return ligado;
    }
}
