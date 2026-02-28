namespace HelloWorld;

public class Dicionarios
{
    public static void Executar()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Um");
        dicionario.Add(2, "Dois");

        foreach (KeyValuePair<int, string> item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }
    }
}
