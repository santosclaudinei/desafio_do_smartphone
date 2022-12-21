namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public string Numero { get; set; }

    public string Modelo { get; set; }

    public string Imei { get; set; }

    public int Memoria { get; set; }

    public void Ligar() => Console.WriteLine("Ligando...");

    public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");

    public void MostraConfiguracao(string modelo, int memoria) => 
        Console.WriteLine($"Aparelho {modelo} com {memoria} GB de Ram");

    public abstract void InstalarAplicativo(string nomeApp);
}