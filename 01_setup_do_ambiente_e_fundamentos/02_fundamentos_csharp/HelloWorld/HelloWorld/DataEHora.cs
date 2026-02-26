using System.Globalization;

namespace HelloWorld;

public class DataEHora
{
    public static void Executar()
    {
        DateOnly dia = new DateOnly(2013, 12, 1);

        string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine(diaEmTexto);

        DateTime dial = new DateTime(2013, 12, 1);
        Console.WriteLine(dial);


        // vai pegar o valor da maquina local
        DateTime hojeLocal = DateTime.Now;
        Console.WriteLine(hojeLocal);

        // vai pegar o valor do tempo universal coordenado (UTC)
        DateTime hoje = DateTime.UtcNow;
        Console.WriteLine(hoje);

        DateTime novaData = hoje.AddDays(1);
        Console.WriteLine(novaData);
    }
}

