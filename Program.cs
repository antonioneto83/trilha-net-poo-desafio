using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("12345", "Nokia", "111111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("67890", "iPhone", "222222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
