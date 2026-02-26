namespace HelloWorld;

public class Variaveis
{
    public static void Executar()
    {
        // var permite que o tipo seja inferido pelo compilador, ou seja, o tipo da variavel é definido a partir do valor atribuido a ela
        // tipo nomeVariavel permite que o tipo seja definido explicitamente, ou seja, o tipo da variavel é definido pelo programador

        string nome = "Lucas";
        int meuNumero = 7;

        var nome2 = "Lucas";

        string meuSobrenome;
        var meuSobrenome2 = "Lucas";

        var variavel = DateTime.UtcNow;
    }
}

