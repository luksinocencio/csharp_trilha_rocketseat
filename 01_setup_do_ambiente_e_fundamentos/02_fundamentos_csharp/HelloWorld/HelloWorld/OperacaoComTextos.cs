using System.Text;

namespace HelloWorld;

public class OperacaoComTextos
{
    public static void Executar()
    {
        string texto1 = "A primeira frase.";
        string texto2 = "Segunda frase";
        string paragrafo = texto1 + " " + 7 + true + texto2;
        Console.WriteLine(paragrafo);

        // \t -> espaço 
        // \n -> quebra de linha
        string caminho = "C:\\teste";
        Console.WriteLine(caminho);

        string paragrafo2 = $"A forma frase. {7} {true} segunda frase.";
        Console.WriteLine(paragrafo2);

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("paragrafo");
        stringBuilder.Append("paragrafo2");

        string resultado = stringBuilder.ToString();
        Console.WriteLine(paragrafo2);

        string texto = "O Usuario {0} gosta do numero {1}";
        string resultado2 = string.Format(texto, "Lucas", 7);

        Console.WriteLine(resultado2);
    }
}

